﻿using UnityEngine;
using System.Collections;

public class gameStore : MonoBehaviour {
	public AudioClip Click;
	public UIToolkit backManager;
	
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//game store
		var backButton = UIButton.create(backManager, "back_normal.png","back_active.png",0,0);
		backButton.positionFromCenter( 0.43f, 0.070f );
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.setSize(backButton.width / scaleFactor, backButton.height / scaleFactor);
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		}
}
