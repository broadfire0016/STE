using UnityEngine;
using System.Collections;

public class EggBreakScript : MonoBehaviour {
	
	GameObject spawnBrokenEgg;
	ObjectPooler brokenEgg;
	public GameObject BreakEgg;

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.name == "Floor" || other.gameObject.name == "Cart" || other.gameObject.name == "basketwall"){
			brokenEgg =  GameObject.Find("brokenEggPooler").GetComponent<ObjectPooler>();
			spawnBrokenEgg = brokenEgg.GetPooledObject();
			spawnBrokenEgg.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
			spawnBrokenEgg.SetActive(true);
		}
	}
}
