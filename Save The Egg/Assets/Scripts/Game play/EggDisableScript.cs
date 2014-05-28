﻿//This Script is attached to the egg, its function is to set the egg back to the pool after a Trigger or a Collision happens.
//author: Levi Joy Lim

using UnityEngine;
using System.Collections;

public class EggDisableScript : MonoBehaviour {



	void OnCollisionEnter(Collision other) {
		if(other.gameObject.name == "Floor" || other.gameObject.name == "Cart" || other.gameObject.name == "basketwall"){
			gameObject.rigidbody.isKinematic = false;
			Invoke ("Destroy", 0.1f);
		}
		if(other.gameObject.name == "Ball" || other.gameObject.name == "Ball(Clone)" ){
			gameObject.rigidbody.isKinematic = false;
			//gameObject.rigidbody.velocity = (new Vector3 (-0.5f, 0.5f, 0f) * 3f);
			if (Application.loadedLevelName != "Level2")
				gameObject.transform.Translate (new Vector3(-1f, 0f, 0f));
			else
				gameObject.transform.Translate (new Vector3(0f,0f,-1f));

			//Invoke("RemoveBrokenEgg",0.5f);			
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
	
}
