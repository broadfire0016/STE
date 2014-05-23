using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {
	
	
	decimal seconds = 3;
	
	void Start () {
	  InvokeRepeating("counter",1,1);
	}

	void counter(){
		if (seconds >0){
	 	--seconds;
	 }

	 if(seconds <= 0){
	 	Application.LoadLevel("Level1");

	 }

	}
}
