using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {
	
	public AudioClip Click;
	public GameObject basket;
	public GameObject camera;
	public float newPosZ;
	float currentPosX, currentPosY, currentPosZ, scaleFactor;
	float pauseDefaultx, pauseDefaultY;
	public UIToolkit buttonsManager;
	UIToggleButton settingBtn;
	UIButton replayButton, homeButton;
	// pause Button Function
	void Start () {
		scaleFactor = ScaleFactor.GetScaleFactor ();
		var settingButton = UIToggleButton.create(buttonsManager,"pause_normal2.png", "play_normal2.png","pause_normal2.png",0,0);
		settingBtn = settingButton;
		settingButton.positionFromTopLeft( 0.28f, 0.9f );
		currentPosX = camera.transform.position.x;
		currentPosY = camera.transform.position.y;
		currentPosZ = camera.transform.position.z;
		settingButton.onToggle += (sender, selected) => check (sender);
		settingButton.selected = false;
		pauseDefaultx = settingButton.width/scaleFactor ;
		pauseDefaultY = settingButton.height / scaleFactor;

#if UNITY_EDITOR
		settingButton.setSize(settingButton.width/scaleFactor , settingButton.height / scaleFactor);
#endif


#if UNITY_IOS
		if (Screen.width == 640 && Screen.height == 1136 || Screen.width == 640 && Screen.height == 960){
			settingButton.setSize(settingButton.width/scaleFactor * 0.4f , settingButton.height / scaleFactor * 0.4f);
		}
#endif

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
			homeButton.setSize(replayButton.width/scaleFactor * 1.3f, replayButton.height/scaleFactor * 1.3f);
			settingBtn.positionFromTopLeft(0.45f,0.445f);
			settingBtn.setSize(replayButton.width/scaleFactor * 1.3f, replayButton.height/scaleFactor * 1.3f);
			Time.timeScale = 0;
			camera.transform.position = new Vector3(currentPosX,currentPosY, newPosZ);
			basket.SetActive(false);
		}
		else{
			Time.timeScale = 1;
			camera.transform.position = new Vector3(currentPosX,currentPosY, currentPosZ);
			replayButton.positionFromTopLeft(2f, 2f);
			homeButton.positionFromTopLeft(2f, 2f);
			settingBtn.positionFromTopLeft( 0.28f, 0.9f );
			settingBtn.setSize(pauseDefaultx , pauseDefaultY);
			basket.SetActive(true);
		}
	}

}
