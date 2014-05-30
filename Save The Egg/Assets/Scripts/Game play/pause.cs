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
	UIButton pauseButton, resumeButton;
	UIButton replayButton, homeButton;
	string activePng = "pause_active2.png";
	string normalPng = "pause_normal2.png";
	// pause Button Function
	
	void Start () {
		Time.timeScale = 1;
		scaleFactor = ScaleFactor.GetScaleFactor ();
		pauseButton = UIButton.create(buttonsManager, normalPng, activePng,0,0);
		resumeButton = UIButton.create(buttonsManager, "play_active.png", "play_normal2.png",0,0);
		replayButton = UIButton.create(buttonsManager,"resume_normal.png","resume_active.png",0,0);
		homeButton = UIButton.create(buttonsManager,"home_normal.png","home_active.png",0,0);
		pauseButton.positionFromTopLeft( 0.24f, 0.9f );
		replayButton.positionFromTopLeft(2f, 2f);
		homeButton.positionFromTopLeft(2f, 2f);
		resumeButton.positionFromTopLeft(2f,2f);
		currentPosX = objectCamera.transform.position.x;
		currentPosY = objectCamera.transform.position.y;
		currentPosZ = objectCamera.transform.position.z;
		pauseButton.onTouchUpInside += sender => Time.timeScale = 0;


#if UNITY_EDITOR || UNITY_IOS
		//settingButton.setSize(settingButton.width/scaleFactor + 12 , settingButton.height / scaleFactor +12);
		//Iphone 4
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) {
			pauseButton.setSize(pauseButton.width/scaleFactor * 1f , pauseButton.height / scaleFactor * 1f);
			resumeButton.setSize(resumeButton.width/scaleFactor * 1f, resumeButton.height/scaleFactor * 1f);
			replayButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
			homeButton.setSize(homeButton.width/scaleFactor * 1f, homeButton.height/scaleFactor * 1f);
			pauseDefaultx = pauseButton.width/scaleFactor * 1f;
			pauseDefaultY = pauseButton.height / scaleFactor * 1f;
		}
		//Ipad2 and Ipad4
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640 || Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) {
			pauseButton.setSize(pauseButton.width/scaleFactor * 1f , pauseButton.height / scaleFactor * 1f);
			resumeButton.setSize(resumeButton.width/scaleFactor * 1f, resumeButton.height/scaleFactor * 1f);
			replayButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
			homeButton.setSize(homeButton.width/scaleFactor * 1f, homeButton.height/scaleFactor * 1f);
			pauseDefaultx = pauseButton.width/scaleFactor * 1f;
			pauseDefaultY = pauseButton.height / scaleFactor * 1f;
		}
		//Iphone 5
		if (Screen.width == 411 && Screen.height == 730 ||Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136){
			pauseButton.setSize(pauseButton.width/scaleFactor * 1f , pauseButton.height / scaleFactor * 1f);
			resumeButton.setSize(resumeButton.width/scaleFactor * 1f, resumeButton.height/scaleFactor * 1f);
			replayButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
			homeButton.setSize(homeButton.width/scaleFactor * 1f, homeButton.height/scaleFactor * 1f);
			pauseDefaultx = pauseButton.width/scaleFactor * 1f;
			pauseDefaultY = pauseButton.height / scaleFactor * 1f;
		}
#endif

	}

	void Update(){
		if (Time.timeScale == 0) {
			pauseButton.positionFromTopLeft(2f,2f);
			replayButton.positionFromTopLeft(0.45f, 0.21f);
			replayButton.onTouchUpInside += sender1 => Application.LoadLevel("Level1");
			homeButton.positionFromTopLeft(0.45f, 0.67f);
			homeButton.onTouchUpInside += sender1 => Application.LoadLevel("AGAIN");
			resumeButton.positionFromTopLeft(0.45f,0.445f);
			resumeButton.onTouchUpInside += sender1 => Time.timeScale = 1;
			objectCamera.transform.position = new Vector3(currentPosX,currentPosY, newPosZ);
		}
		else if(Time.timeScale == 1){
			pauseButton.positionFromTopLeft( 0.24f, 0.9f );
			pauseButton.setSize(pauseDefaultx , pauseDefaultY);
			objectCamera.transform.position = new Vector3(currentPosX,currentPosY, currentPosZ);
			replayButton.positionFromTopLeft(2f, 2f);
			homeButton.positionFromTopLeft(2f, 2f);
			resumeButton.positionFromTopLeft(2f,2f);
		}
	}

	/*void check(){
		if (sender.selected){

			replayButton = UIButton.create(buttonsManager,"resume_normal.png","resume_active.png",0,0);

			//replayButton.setSize(replayButton.width/scaleFactor * 1.2f, replayButton.height/scaleFactor * 1.2f);

			homeButton = UIButton.create(buttonsManager,"home_normal.png","home_active.png",0,0);

			//homeButton.setSize(replayButton.width/scaleFactor + 27, replayButton.height/scaleFactor + 29);
			settingButton.positionFromTopLeft(0.45f,0.445f);
			settingButton.setSize(replayButton.width/scaleFactor + 27, replayButton.height/scaleFactor +29);
			Time.timeScale = 0;

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
	}*/
}
