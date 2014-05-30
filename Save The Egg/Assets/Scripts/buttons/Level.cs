﻿//Shows Score for the level complete scene and game Over Scene
//Author Levi

using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
	public UIToolkit textManager;
	private UITextInstance scoretext1, scoretext2;
	UIText scoreText;

	// Use this for initialization
	void Start () {
		scoreText = new UIText(textManager, "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png");
		scoretext1 = scoreText.addTextInstance(string.Format("{0}", Main.getScore()), 0, 0 );
		scoretext1.color = Color.black;
		scoretext1.textScale = 3f;
		if (Application.loadedLevelName != "gameOver"){
			scoretext2 = scoreText.addTextInstance(string.Format("{0}", Main.getTargetScore()), 0, 0 );
			scoretext2.positionFromCenter(0.17f, 0.06f);
			scoretext2.color = Color.black;
		}

#if UNITY_EDITOR || UNITY_IOS
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) {
			scoretext1.positionFromTopLeft(0.455f, 0.455f);
		}
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640 || Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) {
			scoretext1.positionFromTopLeft(0.455f, 0.455f);
		}
		if (Screen.width == 411 && Screen.height == 730 ||Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136){
			scoretext1.positionFromTopLeft(0.455f, 0.445f);
		}
#endif
	}

	void Update(){
		scoretext1.text = string.Format("{0}", Main.getScore());
		scoretext2.text = string.Format("{0}", Main.getTargetScore()+15);
	}
}
