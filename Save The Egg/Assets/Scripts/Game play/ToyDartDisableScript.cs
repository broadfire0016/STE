using UnityEngine;
using System.Collections;

public class ToyDartDisableScript : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter (Collision other) {
		Invoke ("Destroy", 2f);
	}

	public void Destroy(){
		//gameObject.rigidbody.Sleep ();
		gameObject.SetActive (false);
	}

	void OnDisable(){
		CancelInvoke ();
	}


}
