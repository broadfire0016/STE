//Attach to spawner Object. It spawns random egg generated from the Object Pooler.
//Author Levi Joy Lim

using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	public float priority = 0.5f;
	bool nestSpawn = false;

	GameObject spawnWhiteEgg, spawnRottenEgg, spawnGoldEgg, spawnBlueEgg, spawnRedEgg, spawnNest;

	AudioScript audioplay;
	
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
			spawnWhiteEgg.rigidbody.isKinematic = true;
			spawnWhiteEgg.transform.rotation = gameObject.transform.rotation;
			spawnWhiteEgg.transform.position = gameObject.transform.position;
			spawnWhiteEgg.SetActive(true);
			break;
		case 2:
			ObjectPooler RottenEgg = GameObject.Find("Rotten").GetComponent<ObjectPooler>();
			spawnRottenEgg = RottenEgg.GetPooledObject();
			spawnRottenEgg.rigidbody.isKinematic = true;
			spawnRottenEgg.transform.position = gameObject.transform.position;
			spawnRottenEgg.transform.rotation = gameObject.transform.rotation;
			spawnRottenEgg.SetActive(true);
			break;
		case 3: 
			ObjectPooler GoldEgg = GameObject.Find("Gold").GetComponent<ObjectPooler>();
			spawnGoldEgg = GoldEgg.GetPooledObject();
			spawnGoldEgg.rigidbody.isKinematic = true;
			spawnGoldEgg.transform.position = gameObject.transform.position;
			spawnGoldEgg.transform.rotation = gameObject.transform.rotation;
			spawnGoldEgg.SetActive(true);
			break;
		case 4: 
			ObjectPooler BlueEgg = GameObject.Find("Blue").GetComponent<ObjectPooler>();
			spawnBlueEgg = BlueEgg.GetPooledObject();
			spawnBlueEgg.rigidbody.isKinematic = true;
			spawnBlueEgg.transform.position = gameObject.transform.position;
			spawnBlueEgg.transform.rotation = gameObject.transform.rotation;
			spawnBlueEgg.SetActive(true);
			break;
		case 5: 
			ObjectPooler RedEgg = GameObject.Find("Red").GetComponent<ObjectPooler>();
			spawnRedEgg = RedEgg.GetPooledObject();
			spawnRedEgg.rigidbody.isKinematic = true;
			spawnRedEgg.transform.position = gameObject.transform.position;
			spawnRedEgg.transform.rotation = gameObject.transform.rotation;
			spawnRedEgg.SetActive(true);
			break;
		}
	}

	public int spawnEgg () {
		int randomEgg = Random.Range(1,6);
		return randomEgg;
	}
	
	void OnTriggerExit(Collider egg){
		if (egg.gameObject.name == "White Egg(Clone)" || egg.gameObject.name == "Rotten Egg(Clone)" || egg.gameObject.name == "Gold Egg(Clone)" ||
		    egg.gameObject.name == "Blue Egg(Clone)" || egg.gameObject.name == "Red Egg(Clone)" ){
				Invoke("Start",priority);
		}
	}
}
