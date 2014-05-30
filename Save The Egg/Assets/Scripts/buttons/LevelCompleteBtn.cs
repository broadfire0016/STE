﻿//Buttons in level Complete Scene
//Author: Levi

using UnityEngine;
using System.Collections;

public class LevelCompleteBtn : MonoBehaviour {
	private int level;
	public UIToolkit buttonsManager;
	// Use this for initialization
	void Start () {

		level = Main.getLevel();
		var scaleFactor = ScaleFactor.GetScaleFactor ();

		var menuButton = UIButton.create(buttonsManager, "menu_normal.png","menu.png",0,0);
		//menuButton.positionFromCenter( 0.29f, -0.12f );
		menuButton.positionFromBottomLeft( 0.29f, -0.12f );
		menuButton.setSize(menuButton.width/ scaleFactor + 10, menuButton.height / scaleFactor + 15);
		menuButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		menuButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");

		if (level <= 10){
			var nextButton = UIButton.create(buttonsManager, "next_normal.png","next.png",0,0);
			nextButton.positionFromCenter( 0.29f, 0.12f );
			nextButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
			nextButton.onTouchUpInside += sender => Application.LoadLevel("Level"+level);
		}
	}
}