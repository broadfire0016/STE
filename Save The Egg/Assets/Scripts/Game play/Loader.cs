using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	private static Loader instance;
	
	void Awake(){
		if (instance != null && instance != this && Application.loadedLevelName != "levelComplete"){
			Destroy(this.gameObject);
			return;
		}
		else{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	

}
