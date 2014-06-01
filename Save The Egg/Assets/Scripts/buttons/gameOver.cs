//Game Over Scene
//Author : Levi Lim & Aiza Aviso

using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	public UIToolkit buttonsManager;
	AudioScript audioplay;

	void Awake(){
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
	}
	// Use this for initialization
	void Start () {
		audioplay.PlayGameOver ();
		AudioScript.status = false;	
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var menuButton = UIButton.create(buttonsManager, "home_normal.png","home_active.png",0,0);
		menuButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		menuButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		menuButton.onTouchUpInside += sender => AudioScript.status = false;	
		menuButton.touchDownSound = audioplay.getSoundClip();
		menuButton.setSize(menuButton.width/ scaleFactor * 0.8f, menuButton.height / scaleFactor * 0.8f);
		menuButton.positionFromCenter( 0.26f, -0.10f );
	
		//retry
		var retryButton = UIButton.create(buttonsManager,"retry_normal.png","retry.png",0,0);
		retryButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		retryButton.onTouchUpInside += sender => Application.LoadLevel("Level1");
		retryButton.onTouchUpInside += sender => AudioScript.status = true;	
		retryButton.touchDownSound = audioplay.getSoundClip();
		retryButton.setSize(retryButton.width/ scaleFactor + 27, retryButton.height / scaleFactor +18);

		menuButton.positionFromCenter( 0.26f, -0.13f );
		retryButton.parentUIObject = menuButton;
		retryButton.positionFromCenter( 0f, 2f );

	}
}
