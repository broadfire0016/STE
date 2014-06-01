//Ball Spawner Script. Spawns ball from the pooler after ball was swipe by the player.
//Author: Levi

using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour {

	//public AudioClip ball;
	AudioScript audioplay;

	// Use this for initialization
	void Start () {
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
		Invoke ("callBall", 1f);
	}

	void OnTriggerEnter(Collider dart){

	}

	void OnTriggerExit(Collider dart){
		if (dart.gameObject.name == "Ball" || dart.gameObject.name == "Ball(Clone)") {
			Invoke ("callBall", 1f);
			audioplay.PlayGameSound();
		}
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
