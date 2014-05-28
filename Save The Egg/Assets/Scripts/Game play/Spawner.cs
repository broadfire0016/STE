﻿using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public float priority = 0.5f;
	int eggExit = 0;
	bool nestSpawn = false;

	GameObject spawnWhiteEgg, spawnRottenEgg, spawnGoldEgg, spawnBlueEgg, spawnRedEgg, spawnNest;

	void Start(){
		Invoke ("callEgg", (priority));
		Invoke ("callNest", (priority));

	}

	void callNest(){
		if (nestSpawn == false){
			ObjectPooler nest = GameObject.Find("nestPooler").GetComponent<ObjectPooler>();
			spawnNest = nest.GetPooledObject();
			spawnNest.transform.position = new Vector3(gameObject.transform.position.x - 0.5f, gameObject.transform.position.y + 0.2f, gameObject.transform.position.z - 0.3f);
			spawnNest.SetActive(true);
			nestSpawn = true;
		}
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
		case 4: 
			ObjectPooler BlueEgg = GameObject.Find("Blue").GetComponent<ObjectPooler>();
			spawnBlueEgg = BlueEgg.GetPooledObject();
			//spawnGoldEgg.rigidbody.Sleep();
			spawnBlueEgg.rigidbody.isKinematic = true;
			spawnBlueEgg.transform.position = gameObject.transform.position;
			spawnBlueEgg.transform.rotation = gameObject.transform.rotation;
			spawnBlueEgg.SetActive(true);
			//spawnGoldEgg.rigidbody.isKinematic = false;
			break;
		case 5: 
			ObjectPooler RedEgg = GameObject.Find("Red").GetComponent<ObjectPooler>();
			spawnRedEgg = RedEgg.GetPooledObject();
			//spawnGoldEgg.rigidbody.Sleep();
			spawnRedEgg.rigidbody.isKinematic = true;
			spawnRedEgg.transform.position = gameObject.transform.position;
			spawnRedEgg.transform.rotation = gameObject.transform.rotation;
			spawnRedEgg.SetActive(true);
			//spawnGoldEgg.rigidbody.isKinematic = false;
			break;
		}
	}

	public int spawnEgg () {
		int randomEgg = Random.Range(1,6);
		return randomEgg;
	}

	void OnTriggerEnter(Collider egg){
		//if (egg.gameObject.name == "White Egg(Clone)" || egg.gameObject.name == "Rotten Egg(Clone)" || egg.gameObject.name == "Gold Egg(Clone)"){
		//eggExit++;
		//}
	}

	void OnTriggerExit(Collider egg){
		if (egg.gameObject.name == "White Egg(Clone)" || egg.gameObject.name == "Rotten Egg(Clone)" || egg.gameObject.name == "Gold Egg(Clone)" ||
		    egg.gameObject.name == "Blue Egg(Clone)" || egg.gameObject.name == "Red Egg(Clone)" ){
				Invoke("Start",priority);
		}
	}
}



