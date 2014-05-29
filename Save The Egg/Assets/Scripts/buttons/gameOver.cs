﻿using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour {

	public UIToolkit buttonsManager;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var menuButton = UIButton.create(buttonsManager, "home_normal.png","home_active.png",0,0);
		menuButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		menuButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		menuButton.setSize(menuButton.width/ scaleFactor + 11, menuButton.height / scaleFactor +4);
		
		
		//retry
		var retryButton = UIButton.create(buttonsManager,"retry_normal.png","retry.png",0,0);
		retryButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		retryButton.onTouchUpInside += sender => Application.LoadLevel("Level1");
		retryButton.setSize(retryButton.width/ scaleFactor + 27, retryButton.height / scaleFactor +18);


		#if UNITY_EDITOR
		if (Screen.width == 487 && Screen.height == 730) { //iphone4
			menuButton.positionFromCenter( 0.27f, -0.15f );
			retryButton.positionFromCenter( 0.27f, 0.09f );
		}
		if (Screen.width == 548 && Screen.height == 730) { //ipad
			menuButton.positionFromCenter( 0.26f, -0.15f );
			retryButton.positionFromCenter( 0.26f, 0.07f );
		}
		if (Screen.width == 411 && Screen.height == 730){ //iphone 5
			menuButton.positionFromCenter( 0.26f, -0.15f );
			retryButton.positionFromCenter( 0.26f, 0.09f );
		}
		#endif

		#if UNITY_IOS
		if (Screen.width == 640 && Screen.height == 960) {
			menuButton.positionFromCenter( 0.25f, -0.09f );
			retryButton.positionFromCenter( 0.25f, 0.07f );
		}
		if (Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) {
			menuButton.positionFromCenter( 0.23f, -0.10f );
			retryButton.positionFromCenter( 0.23f, 0.07f );
		}
		
		if (Screen.width == 640 && Screen.height == 1136){
			menuButton.positionFromCenter( 0.22f, -0.10f );
			retryButton.positionFromCenter( 0.22f, 0.07f );
		}
		
		#endif


	}
}
