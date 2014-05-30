//Pause Function Button
//Author: Levi Joy Lim && Aiza Aviso

using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	
	public AudioClip Click;
	public GameObject basket;
	public GameObject objectCamera;
	public float newPosZ;
	public UIToolkit buttonsManager;
	float currentPosX, currentPosY, currentPosZ, scaleFactor;
	float pauseDefaultx, pauseDefaultY;
	UIToggleButton settingButton;
	UIButton replayButton, homeButton;
	string activePng = "play_active.png";
	string normalPng = "pause_normal2.png";
	// pause Button Function
	
	void Start () {
		scaleFactor = ScaleFactor.GetScaleFactor ();
		settingButton = UIToggleButton.create(buttonsManager, normalPng, activePng ,normalPng,0,0);
		currentPosX = objectCamera.transform.position.x;
		currentPosY = objectCamera.transform.position.y;
		currentPosZ = objectCamera.transform.position.z;
		settingButton.onToggle += (sender, selected) => check (sender);
		settingButton.selected = false;
		pauseDefaultx = settingButton.width/scaleFactor + 12 ;
		pauseDefaultY = settingButton.height / scaleFactor + 12;

#if UNITY_EDITOR || UNITY_IOS
		//settingButton.setSize(settingButton.width/scaleFactor + 12 , settingButton.height / scaleFactor +12);
		//Iphone 4
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) {
			settingButton.positionFromTopLeft( 0.24f, 0.9f );
			settingButton.setSize(settingButton.width/scaleFactor * 2f , settingButton.height / scaleFactor * 2f);
			replayButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
			homeButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
		}
		//Ipad2 and Ipad4
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640 || Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) {
			settingButton.positionFromTopLeft( 0.24f, 0.9f );
			settingButton.setSize(settingButton.width/scaleFactor * 1f , settingButton.height / scaleFactor * 1f);
			replayButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
			homeButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
		}
		//Iphone 5
		if (Screen.width == 411 && Screen.height == 730 ||Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136){
			settingButton.positionFromTopLeft( 0.24f, 0.9f );
			settingButton.setSize(settingButton.width/scaleFactor * 2f , settingButton.height / scaleFactor * 2f);
			replayButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
			homeButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
		}
#endif

	}

	void Update(){
		if (Time.timeScale == 0) {
			activePng = "play_active.png";
			normalPng = "play_normal2.png";
			settingButton.refreshPosition();
		}
	}

	void check(UIToggleButton sender){
		if (sender.selected){

			replayButton = UIButton.create(buttonsManager,"resume_normal.png","resume_active.png",0,0);
			replayButton.positionFromTopLeft(0.45f, 0.21f);
			replayButton.setSize(replayButton.width/scaleFactor * 1.2f, replayButton.height/scaleFactor * 1.2f);
			replayButton.onTouchUpInside += sender1 => Application.LoadLevel("Level1");
			homeButton = UIButton.create(buttonsManager,"home_normal.png","home_active.png",0,0);
			homeButton.positionFromTopLeft(0.45f, 0.67f);
			homeButton.onTouchUpInside += sender1 => Application.LoadLevel("AGAIN");
			homeButton.setSize(replayButton.width/scaleFactor + 27, replayButton.height/scaleFactor + 29);
			settingButton.positionFromTopLeft(0.45f,0.445f);
			settingButton.setSize(replayButton.width/scaleFactor + 27, replayButton.height/scaleFactor +29);
			Time.timeScale = 0;
			objectCamera.transform.position = new Vector3(currentPosX,currentPosY, newPosZ);
			basket.SetActive(false);
		}
		else{
			Time.timeScale = 1;
			objectCamera.transform.position = new Vector3(currentPosX,currentPosY, currentPosZ);
			replayButton.positionFromTopLeft(2f, 2f);
			homeButton.positionFromTopLeft(2f, 2f);
			settingButton.positionFromTopLeft( 0.24f, 0.9f );
			settingButton.setSize(pauseDefaultx , pauseDefaultY);
			basket.SetActive(true);
		}
	}
}
