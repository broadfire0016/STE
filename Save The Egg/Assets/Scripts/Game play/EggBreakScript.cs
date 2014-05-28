using UnityEngine;
using System.Collections;

public class EggBreakScript : MonoBehaviour {
	
	GameObject spawnWhiteBrokenEgg, spawnGoldBrokenEgg;
	ObjectPooler whitebrokenEgg, goldbrokenEgg, redbrokenEgg, bluebrokenEgg;
	public GameObject BreakEgg;

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.name == "Floor" || other.gameObject.name == "Cart" || other.gameObject.name == "basketwall"){
			whitebrokenEgg =  GameObject.Find("brokenEggPooler").GetComponent<ObjectPooler>();
			spawnWhiteBrokenEgg = whitebrokenEgg.GetPooledObject();
			spawnWhiteBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
			spawnWhiteBrokenEgg.SetActive(true);
			Invoke("RemoveBrokenEgg",5f);
		}
	}

	void RemoveBrokenEgg(){
		spawnWhiteBrokenEgg.SetActive(false);
	}
}
