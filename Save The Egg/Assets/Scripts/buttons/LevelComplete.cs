//Buttons in level Complete Scene
//Author: Levi

using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour {
	private int level;
	public UIToolkit buttonsManager;
	AudioScript audioplay;
	UIButton menuButton, nextButton;
	// Use this for initialization

	void Awake(){
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
	}

	void Start () {
		level = Main.getLevel();
		audioplay.PlayLevelComplete ();
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		menuButton = UIButton.create(buttonsManager, "menu_normal.png","menu.png",0,0);
		menuButton.positionFromBottomLeft( 0.29f, -0.12f );
		menuButton.setSize(menuButton.width/ scaleFactor + 10, menuButton.height / scaleFactor + 15);
		menuButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		menuButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		menuButton.onTouchUpInside += sender => AudioScript.status = false;
		menuButton.touchDownSound = audioplay.getSoundClip();
		AudioScript.status = false;

		if (level <= 10){
			nextButton = UIButton.create(buttonsManager, "next_normal.png","next.png",0,0);
			nextButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
			nextButton.setSize(nextButton.width/ scaleFactor * 1f , nextButton.height / scaleFactor * 1.1f);
			nextButton.onTouchUpInside += sender => Application.LoadLevel("Level"+level);
			nextButton.onTouchUpInside += sender => AudioScript.status = true;
			nextButton.touchDownSound = audioplay.getSoundClip();
		}

		menuButton.positionFromCenter( 0.29f, -0.12f );
		nextButton.parentUIObject = menuButton;
		nextButton.positionFromCenter( 0f, 2f );
	}
}