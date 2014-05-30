// Script attached to Main Menu UI, incharged of the buttons and state of sound and music in the game.
//Author: Aiza Aviso

using UnityEngine;
using System.Collections;

public class Levels_shortcut_btn : MonoBehaviour {
	

 	//private UIButton post1, playBtn, collectBtn, storeBtn, hsBtn, creditsBtn;
	//private UIToggleButton soundBtn, musicBtn; 

	// Use this for initialization
	void Start () {
		//Screen.SetResolution (1536, 2048, true, 60);
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		Time.timeScale = 1;

		print ("Width " + Screen.width + " Height " + Screen.height);
		//Level1
		var L1 = UIButton.create("L1.png","L1.png",0,0);
			L1.onTouchUpInside += sender => Application.LoadLevel("Level1");
			L1.userData = "Click";
			L1.onTouchUp += OnButtonUp;
			L1.onTouchDown += OnButtonDown;
			L1.onTouchUpInside += OnButtonSelect;
			//L2
			var L2 = UIButton.create("L2.png","L2.png",0,0);
			L2.onTouchUpInside += sender => Application.LoadLevel("Level2");
			L2.userData = "Click";
			L2.onTouchUp += OnButtonUp;
			L2.onTouchDown += OnButtonDown;
			L2.onTouchUpInside += OnButtonSelect;
		//L3
			var L3 = UIButton.create("L3.png","L3.png",0,0);
			L3.onTouchUpInside += sender => Application.LoadLevel("Level3");
			L3.userData = "Click";
			L3.onTouchUp += OnButtonUp;
			L3.onTouchDown += OnButtonDown;
			L3.onTouchUpInside += OnButtonSelect;
			//Level4
			var L4 = UIButton.create("L4.png","L4.png",0,0);
			L4.onTouchUpInside += sender => Application.LoadLevel("Level4");
			L4.userData = "Click";
			L4.onTouchUp += OnButtonUp;
			L4.onTouchDown += OnButtonDown;
			L4.onTouchUpInside += OnButtonSelect;
			//Level5
			var L5 = UIButton.create("L5.png","L5.png",0,0);
			L5.onTouchUpInside += sender => Application.LoadLevel("Level5");
			L5.userData = "Click";
			L5.onTouchUp += OnButtonUp;
			L5.onTouchDown += OnButtonDown;
			L5.onTouchUpInside += OnButtonSelect;

			var L6= UIButton.create("L6.png","L6.png",0,0);
			L6.onTouchUpInside += sender => Application.LoadLevel("Level6");
			L6.userData = "Click";
			L6.onTouchUp += OnButtonUp;
			L6.onTouchDown += OnButtonDown;
			L6.onTouchUpInside += OnButtonSelect;

			var L7 = UIButton.create("L7.png","L7.png",0,0);
			L7.onTouchUpInside += sender => Application.LoadLevel("Level7");
			L7.userData = "Click";
			L7.onTouchUp += OnButtonUp;
			L7.onTouchDown += OnButtonDown;
			L7.onTouchUpInside += OnButtonSelect;

			var L8 = UIButton.create("L8.png","L8.png",0,0);
			L8.onTouchUpInside += sender => Application.LoadLevel("Level8");
			L8.userData = "Click";
			L8.onTouchUp += OnButtonUp;
			L8.onTouchDown += OnButtonDown;
			L8.onTouchUpInside += OnButtonSelect;

			var L9 = UIButton.create("L9.png","L9.png",0,0);
			L9.onTouchUpInside += sender => Application.LoadLevel("Level9");
			L9.userData = "Click";
			L9.onTouchUp += OnButtonUp;
			L9.onTouchDown += OnButtonDown;
			L9.onTouchUpInside += OnButtonSelect;

			var L10 = UIButton.create("L10.png","L10.png",0,0);
			L10.onTouchUpInside += sender => Application.LoadLevel("Level8");
			L10.userData = "Click";
			L10.onTouchUp += OnButtonUp;
			L10.onTouchDown += OnButtonDown;
			L10.onTouchUpInside += OnButtonSelect;

			var back = UIButton.create("back_normal2.png","back_active2.png",0,0);
			back.onTouchUpInside += sender => Application.LoadLevel("Level8");

		
	
#if UNITY_EDITOR
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640) {
			L1.positionFromTopLeft (0.10f, 0.30f);
			L1.setSize(L1.width/ scaleFactor, L1.height / scaleFactor * 0.7f);
			L2.positionFromTopLeft (0.17f, 0.30f);
			L2.setSize(L2.width/ scaleFactor, L2.height / scaleFactor * 0.7f);
			L3.positionFromTopLeft (0.24f, 0.30f);
			L3.setSize(L3.width/ scaleFactor, L3.height / scaleFactor * 0.7f);
			L4.positionFromTopLeft (0.31f, 0.30f);
			L4.setSize(L4.width/ scaleFactor, L4.height / scaleFactor * 0.7f);
			L5.positionFromTopLeft (0.38f, 0.30f);
			L5.setSize(L5.width/ scaleFactor, L5.height / scaleFactor * 0.7f);
			L6.positionFromTopLeft (0.45f, 0.30f);
			L6.setSize(L6.width/ scaleFactor, L6.height / scaleFactor * 0.7f);
			L7.positionFromTopLeft (0.52f, 0.30f);
			L7.setSize(L7.width/ scaleFactor, L7.height / scaleFactor * 0.7f);
			L8.positionFromTopLeft (0.59f, 0.30f);
			L8.setSize(L8.width/ scaleFactor, L8.height / scaleFactor * 0.7f);
			L9.positionFromTopLeft (0.66f, 0.30f);
			L9.setSize(L9.width/ scaleFactor, L9.height / scaleFactor * 0.7f);
			L10.positionFromTopLeft (0.73f, 0.30f);
			L10.setSize(L10.width/ scaleFactor, L10.height / scaleFactor * 0.7f);
			back.positionFromTopLeft (0.785f, 0.40f);
			back.setSize(back.width/ scaleFactor, back.height / scaleFactor + 25);
		}
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640) {
			L1.positionFromTopLeft (0.10f, 0.30f);
			L1.setSize(L1.width/ scaleFactor, L1.height / scaleFactor * 0.7f);
			L2.positionFromTopLeft (0.17f, 0.30f);
			L2.setSize(L2.width/ scaleFactor, L2.height / scaleFactor * 0.7f);
			L3.positionFromTopLeft (0.24f, 0.30f);
			L3.setSize(L3.width/ scaleFactor, L3.height / scaleFactor * 0.7f);
			L4.positionFromTopLeft (0.31f, 0.30f);
			L4.setSize(L4.width/ scaleFactor, L4.height / scaleFactor * 0.7f);
			L5.positionFromTopLeft (0.38f, 0.30f);
			L5.setSize(L5.width/ scaleFactor, L5.height / scaleFactor * 0.7f);
			L6.positionFromTopLeft (0.45f, 0.30f);
			L6.setSize(L6.width/ scaleFactor, L6.height / scaleFactor * 0.7f);
			L7.positionFromTopLeft (0.52f, 0.30f);
			L7.setSize(L7.width/ scaleFactor, L7.height / scaleFactor * 0.7f);
			L8.positionFromTopLeft (0.59f, 0.30f);
			L8.setSize(L8.width/ scaleFactor, L8.height / scaleFactor * 0.7f);
			L9.positionFromTopLeft (0.66f, 0.30f);
			L9.setSize(L9.width/ scaleFactor, L9.height / scaleFactor * 0.7f);
			L10.positionFromTopLeft (0.73f, 0.30f);
			L10.setSize(L10.width/ scaleFactor, L10.height / scaleFactor * 0.7f);
			back.positionFromTopLeft (0.85f, 0.40f);
			back.setSize(back.width/ scaleFactor, back.height / scaleFactor + 25);

		}
		if (Screen.width == 411 && Screen.height == 730 || Screen.width == 360 && Screen.height == 640){
			L1.positionFromTopLeft (0.10f, 0.30f);
			L1.setSize(L1.width/ scaleFactor, L1.height / scaleFactor * 0.7f);
			L2.positionFromTopLeft (0.17f, 0.30f);
			L2.setSize(L2.width/ scaleFactor, L2.height / scaleFactor * 0.7f);
			L3.positionFromTopLeft (0.24f, 0.30f);
			L3.setSize(L3.width/ scaleFactor, L3.height / scaleFactor * 0.7f);
			L4.positionFromTopLeft (0.31f, 0.30f);
			L4.setSize(L4.width/ scaleFactor, L4.height / scaleFactor * 0.7f);
			L5.positionFromTopLeft (0.38f, 0.30f);
			L5.setSize(L5.width/ scaleFactor, L5.height / scaleFactor * 0.7f);
			L6.positionFromTopLeft (0.45f, 0.30f);
			L6.setSize(L6.width/ scaleFactor, L6.height / scaleFactor * 0.7f);
			L7.positionFromTopLeft (0.52f, 0.30f);
			L7.setSize(L7.width/ scaleFactor, L7.height / scaleFactor * 0.7f);
			L8.positionFromTopLeft (0.59f, 0.30f);
			L8.setSize(L8.width/ scaleFactor, L8.height / scaleFactor * 0.7f);
			L9.positionFromTopLeft (0.66f, 0.30f);
			L9.setSize(L9.width/ scaleFactor, L9.height / scaleFactor * 0.7f);
			L10.positionFromTopLeft (0.73f, 0.30f);
			L10.setSize(L10.width/ scaleFactor, L10.height / scaleFactor * 0.7f);
			back.positionFromTopLeft (0.85f, 0.40f);
			back.setSize(back.width/ scaleFactor, back.height / scaleFactor + 25);
		}

#endif

#if UNITY_IOS
		if (Screen.width == 640 && Screen.height == 960) {
			L1.positionFromTopLeft (0.10f, 0.30f);
			L1.setSize(L1.width/ scaleFactor, L1.height / scaleFactor * 0.7f);
			L2.positionFromTopLeft (0.17f, 0.30f);
			L2.setSize(L2.width/ scaleFactor, L2.height / scaleFactor * 0.7f);
			L3.positionFromTopLeft (0.24f, 0.30f);
			L3.setSize(L3.width/ scaleFactor, L3.height / scaleFactor * 0.7f);
			L4.positionFromTopLeft (0.31f, 0.30f);
			L4.setSize(L4.width/ scaleFactor, L4.height / scaleFactor * 0.7f);
			L5.positionFromTopLeft (0.38f, 0.30f);
			L5.setSize(L5.width/ scaleFactor, L5.height / scaleFactor * 0.7f);
			L6.positionFromTopLeft (0.45f, 0.30f);
			L6.setSize(L6.width/ scaleFactor, L6.height / scaleFactor * 0.7f);
			L7.positionFromTopLeft (0.52f, 0.30f);
			L7.setSize(L7.width/ scaleFactor, L7.height / scaleFactor * 0.7f);
			L8.positionFromTopLeft (0.59f, 0.30f);
			L8.setSize(L8.width/ scaleFactor, L8.height / scaleFactor * 0.7f);
			L9.positionFromTopLeft (0.66f, 0.30f);
			L9.setSize(L9.width/ scaleFactor, L9.height / scaleFactor * 0.7f);
			L10.positionFromTopLeft (0.73f, 0.30f);
			L10.setSize(L10.width/ scaleFactor, L10.height / scaleFactor * 0.7f);
			back.positionFromTopLeft (0.85f, 0.40f);
			back.setSize(back.width/ scaleFactor, back.height / scaleFactor + 25);
		}
		if (Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) {
			L1.positionFromTopLeft (0.10f, 0.30f);
			L1.setSize(L1.width/ scaleFactor, L1.height / scaleFactor * 0.7f);
			L2.positionFromTopLeft (0.17f, 0.30f);
			L2.setSize(L2.width/ scaleFactor, L2.height / scaleFactor * 0.7f);
			L3.positionFromTopLeft (0.24f, 0.30f);
			L3.setSize(L3.width/ scaleFactor, L3.height / scaleFactor * 0.7f);
			L4.positionFromTopLeft (0.31f, 0.30f);
			L4.setSize(L4.width/ scaleFactor, L4.height / scaleFactor * 0.7f);
			L5.positionFromTopLeft (0.38f, 0.30f);
			L5.setSize(L5.width/ scaleFactor, L5.height / scaleFactor * 0.7f);
			L6.positionFromTopLeft (0.45f, 0.30f);
			L6.setSize(L6.width/ scaleFactor, L6.height / scaleFactor * 0.7f);
			L7.positionFromTopLeft (0.52f, 0.30f);
			L7.setSize(L7.width/ scaleFactor, L7.height / scaleFactor * 0.7f);
			L8.positionFromTopLeft (0.59f, 0.30f);
			L8.setSize(L8.width/ scaleFactor, L8.height / scaleFactor * 0.7f);
			L9.positionFromTopLeft (0.66f, 0.30f);
			L9.setSize(L9.width/ scaleFactor, L9.height / scaleFactor * 0.7f);
			L10.positionFromTopLeft (0.73f, 0.30f);
			L10.setSize(L10.width/ scaleFactor, L10.height / scaleFactor * 0.7f);
			back.positionFromTopLeft (0.85f, 0.40f);
			back.setSize(back.width/ scaleFactor, back.height / scaleFactor + 25);
			
		}
		if (Screen.width == 640 && Screen.height == 1136){
			L1.positionFromTopLeft (0.10f, 0.30f);
			L1.setSize(L1.width/ scaleFactor, L1.height / scaleFactor * 0.7f);
			L2.positionFromTopLeft (0.17f, 0.30f);
			L2.setSize(L2.width/ scaleFactor, L2.height / scaleFactor * 0.7f);
			L3.positionFromTopLeft (0.24f, 0.30f);
			L3.setSize(L3.width/ scaleFactor, L3.height / scaleFactor * 0.7f);
			L4.positionFromTopLeft (0.31f, 0.30f);
			L4.setSize(L4.width/ scaleFactor, L4.height / scaleFactor * 0.7f);
			L5.positionFromTopLeft (0.38f, 0.30f);
			L5.setSize(L5.width/ scaleFactor, L5.height / scaleFactor * 0.7f);
			L6.positionFromTopLeft (0.45f, 0.30f);
			L6.setSize(L6.width/ scaleFactor, L6.height / scaleFactor * 0.7f);
			L7.positionFromTopLeft (0.52f, 0.30f);
			L7.setSize(L7.width/ scaleFactor, L7.height / scaleFactor * 0.7f);
			L8.positionFromTopLeft (0.59f, 0.30f);
			L8.setSize(L8.width/ scaleFactor, L8.height / scaleFactor * 0.7f);
			L9.positionFromTopLeft (0.66f, 0.30f);
			L9.setSize(L9.width/ scaleFactor, L9.height / scaleFactor * 0.7f);
			L10.positionFromTopLeft (0.73f, 0.30f);
			L10.setSize(L10.width/ scaleFactor, L10.height / scaleFactor * 0.7f);
			back.positionFromTopLeft (0.85f, 0.40f);
			back.setSize(back.width/ scaleFactor, back.height / scaleFactor + 25);
		}

#endif	
/*
	void Update(){

		  if (SoundSource.mute == true){
		   playBtn.touchDownSound = Click3;
		   collectBtn.touchDownSound = Click3;
		   storeBtn.touchDownSound = Click3;
		   hsBtn.touchDownSound = Click3;
		   creditsBtn.touchDownSound = Click3;
		  }
		  else{
		   playBtn.touchDownSound = Click;
		   collectBtn.touchDownSound = Click;
		   storeBtn.touchDownSound = Click;
		   hsBtn.touchDownSound = Click;
		   creditsBtn.touchDownSound = Click;
		  }
 	}*/
	

	}

	void OnButtonDown(UIButton obj){
		obj.scale = new Vector3 (1.1f, 1.1f, 1.1f);
	}

	void OnButtonUp(UIButton obj){
		obj.scale = new Vector3 (1f, 1f, 1f);
	}	

	void OnButtonSelect(UIButton obj){
		string btn = (string)obj.userData;
		switch (btn){
			case "Click":
		
		break;
	}}
}