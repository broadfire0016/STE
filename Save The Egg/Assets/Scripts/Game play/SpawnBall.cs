using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Invoke ("callBall", 1f);
	}

	void OnTriggerEnter(Collider dart){
	
	}

	void OnTriggerExit(Collider dart){
		if(dart.gameObject.name == "Ball" || dart.gameObject.name == "Ball(Clone)"/* || dart.gameObject.name == "ToyDart" */)
			Invoke ("callBall", 0.1f);
	}
	
	void callBall()
	{
		ObjectPooler ToyDart = GameObject.Find("BallPooler").GetComponent<ObjectPooler>();
		var spawnToyDart = ToyDart.GetPooledObject();
		spawnToyDart.SetActive(true);
		spawnToyDart.rigidbody.isKinematic = true;
		spawnToyDart.transform.rotation = gameObject.transform.rotation;
		spawnToyDart.transform.position = gameObject.transform.position;
	}
}
