using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	
	public AudioClip Click;
	public GameObject _pause;
	public GameObject basket;
	public GameObject camera;
	public float newPosZ;
	float currentPosX, currentPosY, currentPosZ;
	public UIToolkit buttonsManager;

	// pause Button Function
	void Start () {
		var settingButton = UIToggleButton.create(buttonsManager,"pause_normal2.png", "pause_active2.png","pause_normal2.png",0,0);
		settingButton.positionFromTopLeft( 0.28f, 0.9f );
		currentPosX = camera.transform.position.x;
		currentPosY = camera.transform.position.y;
		currentPosZ = camera.transform.position.z;
		settingButton.onToggle += (sender, selected) => check (sender);
		settingButton.selected = false;
		settingButton.setSize(50f,50f);
	
	}


	void check(UIToggleButton sender){
		if (sender.selected){
			Time.timeScale = 0;
			camera.transform.position = new Vector3(currentPosX,currentPosY, newPosZ);
			basket.SetActive(false);
			_pause.SetActive(true);
		}
		else{
			Time.timeScale = 1;
			camera.transform.position = new Vector3(currentPosX,currentPosY, currentPosZ);
			basket.SetActive(true);
			_pause.SetActive(false);
		}
	}
	
}
