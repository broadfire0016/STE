//loading script
//author: levi

using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {
	AudioScript audioplay;

	decimal seconds = 3;
	
	void Start () {
	  InvokeRepeating("counter",1,1);
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
		audioplay.StopMusic();
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
