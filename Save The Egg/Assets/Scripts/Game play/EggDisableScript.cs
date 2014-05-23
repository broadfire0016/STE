using UnityEngine;
using System.Collections;

public class EggDisableScript : MonoBehaviour {

	void OnCollisionEnter(Collision other) {
		if(other.gameObject.name == "Floor" || other.gameObject.name == "Cart" || other.gameObject.name == "basketwall"){
			Invoke ("Destroy", 0.5f);
		}
		if(other.gameObject.name == "ToyDart(Clone)" || other.gameObject.name == "ToyDart"){
			gameObject.rigidbody.isKinematic = false;
			gameObject.rigidbody.AddForce (new Vector3 (-0.5f, 0.5f, 0f) * 15f);
		}

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "basketBody")
			Invoke("Destroy",0.1f);
	}
	
	void Destroy(){
		gameObject.SetActive (false);
	}

	void Delay(){
		print ("");
	}
	
	void OnDisable(){
		gameObject.rigidbody.isKinematic = true;
		gameObject.rigidbody.AddForce(0,0,0);
		CancelInvoke ();
	}
}
