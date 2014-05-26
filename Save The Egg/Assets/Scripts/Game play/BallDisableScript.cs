using UnityEngine;
using System.Collections;

public class BallDisableScript : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter (Collision other) {
		Invoke ("Destroy", 0.3f);
	}

	public void Destroy(){
		//gameObject.rigidbody.Sleep ();
		gameObject.SetActive (false);
	}

	void OnDisable(){
		CancelInvoke ();
	}


}
