using UnityEngine;
using System.Collections;

public class SpawnDart : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Invoke ("callDart", 1f);
	}

	void OnTriggerEnter(Collider dart){
	
	}

	void OnTriggerExit(Collider dart){
		if(dart.gameObject.name == "Body"/* || dart.gameObject.name == "ToyDart" || dart.gameObject.name == "ToyDart(Clone)"*/)
			Invoke ("callDart", 0.1f);
	}
	
	void callDart()
	{
		ObjectPooler ToyDart = GameObject.Find("DartPooler").GetComponent<ObjectPooler>();
		var spawnToyDart = ToyDart.GetPooledObject();
		spawnToyDart.SetActive(true);
		spawnToyDart.rigidbody.isKinematic = true;
		spawnToyDart.transform.rotation = gameObject.transform.rotation;
		spawnToyDart.transform.position = gameObject.transform.position;
	}
}
