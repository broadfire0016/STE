 //Script when the egg Falls in the floor to make it break;
//Author Levi

using UnityEngine;
using System.Collections;

public class Egg : MonoBehaviour {

	public GameObject BreakEgg;
	GameObject spawnWhiteBrokenEgg, spawnGoldBrokenEgg, spawnRedBrokenEgg, spawnBlueBrokenEgg, spawnRottenBrokenEgg;
	ObjectPooler whitebrokenEgg, goldbrokenEgg, redbrokenEgg, bluebrokenEgg, rottenbrokenEgg;
	AudioScript audioplay;
	
	void Awake(){
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
	}

	void Start(){

	}

	void OnCollisionEnter(Collision other) {

		if(other.gameObject.name == "Ball" || other.gameObject.name == "Ball(Clone)"){
			gameObject.rigidbody.isKinematic = false;
			if (Application.loadedLevelName != "Level2" && Application.loadedLevelName != "Level3")
				gameObject.transform.Translate (new Vector3(-1f, 0f, 0f));
			else
				gameObject.transform.Translate (new Vector3(0f,0f,-1f));		
		}


		if(other.gameObject.name == "Floor" || other.gameObject.name == "Cart" || other.gameObject.name == "basketwall"){

			Destroy();

			if(gameObject.tag == "White Egg"){
				whitebrokenEgg =  GameObject.Find("WhiteBroken").GetComponent<ObjectPooler>();
				spawnWhiteBrokenEgg = whitebrokenEgg.GetPooledObject();
				spawnWhiteBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnWhiteBrokenEgg.SetActive(true);
				Invoke("RemoveWhiteEgg",1f);
				audioplay.PlayBreakEgg();
			}
			if(gameObject.tag== "Gold Egg"){
				goldbrokenEgg =  GameObject.Find("GoldBroken").GetComponent<ObjectPooler>();
				spawnGoldBrokenEgg = goldbrokenEgg.GetPooledObject();
				spawnGoldBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnGoldBrokenEgg.SetActive(true);
				Invoke("RemoveGoldEgg",1f);
				audioplay.PlayBreakEgg();
			}
			if(gameObject.tag == "Red Egg"){
				redbrokenEgg =  GameObject.Find("RedBroken").GetComponent<ObjectPooler>();
				spawnRedBrokenEgg = redbrokenEgg.GetPooledObject();
				spawnRedBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnRedBrokenEgg.SetActive(true);
				Invoke("RemoveRedEgg",1f);
				audioplay.PlayBreakEgg();
			}
			if(gameObject.tag == "Blue Egg"){
				bluebrokenEgg =  GameObject.Find("BlueBroken").GetComponent<ObjectPooler>();
				spawnBlueBrokenEgg = bluebrokenEgg.GetPooledObject();
				spawnBlueBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnBlueBrokenEgg.SetActive(true);
				Invoke("RemoveBlueEgg",1f);
				audioplay.PlayBreakEgg();
			}
			if(gameObject.tag == "Rotten Egg"){
				rottenbrokenEgg =  GameObject.Find("RottenBroken").GetComponent<ObjectPooler>();
				spawnRottenBrokenEgg = rottenbrokenEgg.GetPooledObject();
				spawnRottenBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnRottenBrokenEgg.SetActive(true);
				Invoke("RemoveRottenEgg",1f);
				audioplay.PlayBreakEgg();
			}

		}
	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "basketBody")
			Invoke("Destroy",0.1f);
	}

	void Destroy(){
		gameObject.SetActive (false);
	}
	
	void OnDisable(){
		gameObject.rigidbody.isKinematic = true;
		CancelInvoke ();
	}

	void RemoveWhiteEgg(){
		spawnWhiteBrokenEgg.SetActive(false);
	}
	void RemoveBlueEgg(){
		spawnBlueBrokenEgg.SetActive(false);

	}
	void RemoveGoldEgg(){
		spawnGoldBrokenEgg.SetActive(false);

	}
	void RemoveRedEgg(){
		spawnRedBrokenEgg.SetActive(false);
	}
	void RemoveRottenEgg(){
		spawnRottenBrokenEgg.SetActive(false);
	}
}
