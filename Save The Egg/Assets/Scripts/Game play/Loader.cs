using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	private static Loader instance;
	
	void Awake(){
		if (Loader.instance == null){
			Loader.instance = this;
			GameObject.DontDestroyOnLoad(this.gameObject);
		}
		else{
			Destroy(this.gameObject);
		}
	}

}
