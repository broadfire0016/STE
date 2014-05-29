using UnityEngine;
using System.Collections;

public class EggBreakScript : MonoBehaviour {
	
	public AudioClip fallEgg;
	//public AudioClip fallWhite;
	//public AudioClip fallRed;
	//public AudioClip fallRotten;
//	public AudioClip fallGold;

//	public AudioSource fallingBlue;
//	public AudioSource fallingWhite;
//	public AudioSource fallingRed;
//	public AudioSource fallingRotten;
	public AudioSource fallingEggs;

	GameObject spawnWhiteBrokenEgg, spawnGoldBrokenEgg, spawnRedBrokenEgg, spawnBlueBrokenEgg;
	ObjectPooler whitebrokenEgg, goldbrokenEgg, redbrokenEgg, bluebrokenEgg;
	public GameObject BreakEgg;

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.name == "Floor" || other.gameObject.name == "Cart" || other.gameObject.name == "basketwall"){

			if(BreakEgg.tag == "White Egg"){
				whitebrokenEgg =  GameObject.Find("WhiteBroken").GetComponent<ObjectPooler>();
				spawnWhiteBrokenEgg = whitebrokenEgg.GetPooledObject();
				spawnWhiteBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnWhiteBrokenEgg.SetActive(true);
				Invoke("RemoveWhiteEgg",5f);
				audio.clip = fallEgg;
				audio.Play();
			}
			if(BreakEgg.tag == "Gold Egg"){
				goldbrokenEgg =  GameObject.Find("GoldBroken").GetComponent<ObjectPooler>();
				spawnGoldBrokenEgg = goldbrokenEgg.GetPooledObject();
				spawnGoldBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnGoldBrokenEgg.SetActive(true);
				Invoke("RemoveGoldEgg",5f);
				audio.clip = fallEgg;
				audio.Play();
			}
			if(BreakEgg.tag == "Red Egg"){
				redbrokenEgg =  GameObject.Find("RedBroken").GetComponent<ObjectPooler>();
				spawnRedBrokenEgg = redbrokenEgg.GetPooledObject();
				spawnRedBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnRedBrokenEgg.SetActive(true);
				Invoke("RemoveRedEgg",5f);
				audio.clip = fallEgg;
				audio.Play();
			}
			if(BreakEgg.tag == "Blue Egg"){
				bluebrokenEgg =  GameObject.Find("BlueBroken").GetComponent<ObjectPooler>();
				spawnBlueBrokenEgg = bluebrokenEgg.GetPooledObject();
				spawnBlueBrokenEgg.transform.position = new Vector3(BreakEgg.transform.position.x - 1, BreakEgg.transform.position.y, BreakEgg.transform.position.z);
				spawnBlueBrokenEgg.SetActive(true);
				Invoke("RemoveBlueEgg",5f);
				audio.clip = fallEgg;
				audio.Play();
			}
		}
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
}
