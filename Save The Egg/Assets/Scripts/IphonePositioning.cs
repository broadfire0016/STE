using UnityEngine;
using System.Collections;

public class IphonePositioning : MonoBehaviour {

	public GameObject background, background_pause, leftChicken, rightChicken;

	// Use this for initialization
	void Start () {
	
#if UNITY_EDITOR
		if (Screen.width == 487 && Screen.height == 730) {
			background.transform.localScale = new Vector3(0.95f,background.transform.localScale.y,background.transform.localScale.z);
			background_pause.transform.localScale = new Vector3(0.95f,background.transform.localScale.y,background.transform.localScale.z);
			leftChicken.transform.Translate(new Vector3(0f,0f, -0.7f));
			rightChicken.transform.Translate(new Vector3(0f,0f, 0.7f));
		}

		if (Screen.width == 411 && Screen.height == 730 || Screen.width == 360 && Screen.height == 640){
			background.transform.localScale = new Vector3(0.83f,background.transform.localScale.y,background.transform.localScale.z);
			background_pause.transform.localScale = new Vector3(0.83f,background.transform.localScale.y,background.transform.localScale.z);
			leftChicken.transform.Translate(new Vector3(0f,0f, -1.8f));
			rightChicken.transform.Translate(new Vector3(0f,0f, -1.8f));
		}

#endif

#if UNITY_IOS

		if (Screen.width == 640 && Screen.height == 960) {
			background.transform.localScale = new Vector3(0.95f,background.transform.localScale.y,background.transform.localScale.z);
			background_pause.transform.localScale = new Vector3(0.95f,background.transform.localScale.y,background.transform.localScale.z);
			leftChicken.transform.Translate(new Vector3(0f,0f, -0.7f));
			rightChicken.transform.Translate(new Vector3(0f,0f, 0.7f));
		}

		if (Screen.width == 640 && Screen.height == 1136){
			background.transform.localScale = new Vector3(0.83f,background.transform.localScale.y,background.transform.localScale.z);
			background_pause.transform.localScale = new Vector3(0.83f,background.transform.localScale.y,background.transform.localScale.z);
			leftChicken.transform.Translate(new Vector3(0f,0f, -1.8f));
			rightChicken.transform.Translate(new Vector3(0f,0f,-1.8f));
		}
#endif
	}

}
