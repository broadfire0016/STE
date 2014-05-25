using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public float priority = 0.5f;
	int eggExit = 0;

	GameObject spawnWhiteEgg, spawnRottenEgg, spawnGoldEgg;

	void Start(){
		Invoke ("callEgg", (priority));
	}

	void callEgg(){
		int eggValue = spawnEgg ();

		
		switch (eggValue){
		case 1: 
			ObjectPooler WhiteEgg = GameObject.Find("White").GetComponent<ObjectPooler>();
			spawnWhiteEgg = WhiteEgg.GetPooledObject();
			//spawnWhiteEgg.rigidbody.Sleep();
			spawnWhiteEgg.rigidbody.isKinematic = true;
			spawnWhiteEgg.transform.rotation = gameObject.transform.rotation;
			spawnWhiteEgg.transform.position = gameObject.transform.position;
			spawnWhiteEgg.SetActive(true);
			//spawnWhiteEgg.rigidbody.isKinematic = false;
			break;
		case 2:
			ObjectPooler RottenEgg = GameObject.Find("Rotten").GetComponent<ObjectPooler>();
			spawnRottenEgg = RottenEgg.GetPooledObject();
			//spawnRottenEgg.rigidbody.Sleep();
			spawnRottenEgg.rigidbody.isKinematic = true;
			spawnRottenEgg.transform.position = gameObject.transform.position;
			spawnRottenEgg.transform.rotation = gameObject.transform.rotation;
			spawnRottenEgg.SetActive(true);
			//spawnRottenEgg.rigidbody.isKinematic = false;
			break;
		case 3: 
			ObjectPooler GoldEgg = GameObject.Find("Gold").GetComponent<ObjectPooler>();
			spawnGoldEgg = GoldEgg.GetPooledObject();
			//spawnGoldEgg.rigidbody.Sleep();
			spawnGoldEgg.rigidbody.isKinematic = true;
			spawnGoldEgg.transform.position = gameObject.transform.position;
			spawnGoldEgg.transform.rotation = gameObject.transform.rotation;
			spawnGoldEgg.SetActive(true);
			//spawnGoldEgg.rigidbody.isKinematic = false;
			break;
		}
	}

	public int spawnEgg () {
		int randomEgg = Random.Range(1,4);
		return randomEgg;
	}

	void OnTriggerEnter(Collider egg){
		//if (egg.gameObject.name == "White Egg(Clone)" || egg.gameObject.name == "Rotten Egg(Clone)" || egg.gameObject.name == "Gold Egg(Clone)"){
		//eggExit++;
		//}
	}

	void OnTriggerExit(Collider egg){
		if (egg.gameObject.name == "White Egg(Clone)" || egg.gameObject.name == "Rotten Egg(Clone)" || egg.gameObject.name == "Gold Egg(Clone)"){
				Invoke("Start",priority);
		}
	}
}



