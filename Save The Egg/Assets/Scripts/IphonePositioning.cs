using UnityEngine;
using System.Collections;

public class IphonePositioning : MonoBehaviour {

	public GameObject background, background_pause, leftChicken, rightChicken;

	// Use this for initialization
	void Start () {
	
		if (Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) {
			background.transform.localScale = new Vector3(0.95f,background.transform.localScale.y,background.transform.localScale.z);
			background_pause.transform.localScale = new Vector3(0.95f,background.transform.localScale.y,background.transform.localScale.z);
			leftChicken.transform.Translate(new Vector3(0f,0f, -0.7f));
			rightChicken.transform.Translate(new Vector3(0f,0f, 0.7f));
		}

		if (Screen.width == 411 && Screen.height == 730 || Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136){
			background.transform.localScale = new Vector3(12.83f,21.85f,background.transform.localScale.z);
			background_pause.transform.localScale = new Vector3(0.8611252f,1.056228f,background.transform.localScale.z);
			leftChicken.transform.Translate(new Vector3(0f,0f, -1.8f));
			rightChicken.transform.Translate(new Vector3(0f,0f, 1.8f));
		}
	}

}
