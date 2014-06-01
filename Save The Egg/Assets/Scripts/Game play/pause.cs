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
	AudioScript audioplay;
	
	void Awake(){
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
	}

	// pause Button Function
	void Start () {
		Time.timeScale = 1;
		scaleFactor = ScaleFactor.GetScaleFactor ();
		pauseButton = UIButton.create(buttonsManager, "pause_active2.png", "pause_normal2.png",0,0);
		resumeButton = UIButton.create(buttonsManager, "play_active.png", "play_normal2.png",0,0);
		replayButton = UIButton.create(buttonsManager,"resume_normal.png","resume_active.png",0,0);
		homeButton = UIButton.create(buttonsManager,"home_normal.png","home_active.png",0,0);

		pauseDefaultx = pauseButton.width/scaleFactor * 1f;
		pauseDefaultY = pauseButton.height / scaleFactor * 1f;
		pauseButton.positionFromTopLeft(0.24f, 0.9f);
		pauseButton.setSize(pauseButton.width/scaleFactor * 1f , pauseButton.height / scaleFactor * 1f);

		resumeButton.setSize(resumeButton.width/scaleFactor * 1f, resumeButton.height/scaleFactor * 1f);
		replayButton.setSize(replayButton.width/scaleFactor * 1f, replayButton.height/scaleFactor * 1f);
		homeButton.setSize(homeButton.width/scaleFactor * 1f, homeButton.height/scaleFactor * 1f);

		currentPosX = objectCamera.transform.position.x;
		currentPosY = objectCamera.transform.position.y;
		currentPosZ = objectCamera.transform.position.z;

		pauseButton.onTouchUpInside += sender3 => Time.timeScale = 0;
		replayButton.onTouchUpInside += sender1 => Application.LoadLevel("Level1");
		replayButton.onTouchUpInside += sender1 => audioplay.PlayGameMusic();
		replayButton.onTouchUpInside += sender1 => AudioScript.status = false;
		homeButton.onTouchUpInside += sender2 => Application.LoadLevel("AGAIN");
		resumeButton.onTouchUpInside += sender3 => Time.timeScale = 1;

		pauseButton.touchDownSound = audioplay.getSoundClip();
		replayButton.touchDownSound = audioplay.getSoundClip();
		homeButton.touchDownSound = audioplay.getSoundClip();
		resumeButton.touchDownSound = audioplay.getSoundClip();

		replayButton.positionFromTopLeft(2f, 2f);
		homeButton.positionFromTopLeft(2f, 2f);
		resumeButton.positionFromTopLeft(2f,2f);
	}

	void Update(){
		if (Time.timeScale == 0) {
			pauseButton.positionFromTopLeft(2f,2f);
			replayButton.positionFromCenter(0f, -0.18f);
			homeButton.parentUIObject = replayButton;
			homeButton.positionFromCenter(0f, 1.5f);
			resumeButton.parentUIObject = homeButton;
			resumeButton.positionFromTopLeft(0f,1.5f);
			objectCamera.transform.position = new Vector3(currentPosX,currentPosY, newPosZ);
			AudioScript.status = false;
		}
		else if(Time.timeScale == 1){
			pauseButton.positionFromTopLeft( 0.24f, 0.9f );
			pauseButton.setSize(pauseDefaultx , pauseDefaultY);
			objectCamera.transform.position = new Vector3(currentPosX,currentPosY, currentPosZ);
			replayButton.positionFromTopLeft(2f, 2f);
			homeButton.positionFromTopLeft(2f, 2f);
			resumeButton.positionFromTopLeft(2f,2f);
			AudioScript.status = true;
		}
	}	
}
