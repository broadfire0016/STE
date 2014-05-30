//Ball Spawner Script. Spawns ball from the pooler after ball was swipe by the player.
//Author: Levi

using UnityEngine;
using System.Collections;

public class SpawnBall : MonoBehaviour {

	public AudioClip ball;

	// Use this for initialization
	void Start () {
		Invoke ("callBall", 1f);
	}

	void OnTriggerEnter(Collider dart){
	
	}

	void OnTriggerExit(Collider dart){
		if (dart.gameObject.name == "Ball" || dart.gameObject.name == "Ball(Clone)") {
			Invoke ("callBall", 1f);
			audio.clip = ball;
			audio.volume = 20f;
			audio.Play();
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
