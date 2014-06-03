using UnityEngine;
using System.Collections;

public class LevelShortcuts : MonoBehaviour {

	private UIButton Level1, Level2, Level3, Level4, Level5, Level6, Level7, Level8, Level9, Level10;
	public UIToolkit buttonsManager;
	AudioScript audioplay;

	// Use this for initialization
	void Start () {
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();

		var scaleFactor = ScaleFactor.GetScaleFactor ();

		Level1 = UIButton.create(buttonsManager,"L1.png","L1.png",0,0);
		Level1.setSize(Level1.width / scaleFactor  , Level1.height / scaleFactor);
		Level1.onTouchUpInside += sender => Application.LoadLevel("Level1");
		Level2 = UIButton.create(buttonsManager,"L2.png","L2.png",0,0);
		Level2.setSize(Level2.width / scaleFactor  , Level2.height / scaleFactor);
		Level2.onTouchUpInside += sender => Application.LoadLevel("Level2");
		Level2.onTouchUpInside += sender => Basket.levelShortcutSet(0);
		Level3 = UIButton.create(buttonsManager,"L3.png","L3.png",0,0);
		Level3.setSize(Level3.width / scaleFactor  , Level3.height / scaleFactor);
		Level3.onTouchUpInside += sender => Application.LoadLevel("Level3");
		Level3.onTouchUpInside += sender => Basket.levelShortcutSet(0);
		Level4 = UIButton.create(buttonsManager,"L4.png","L4.png",0,0);
		Level4.setSize(Level4.width / scaleFactor  , Level4.height / scaleFactor);
		Level4.onTouchUpInside += sender => Application.LoadLevel("Level4");
		Level4.onTouchUpInside += sender => Basket.levelShortcutSet(0);
		Level5 = UIButton.create(buttonsManager,"L5.png","L5.png",0,0);
		Level5.setSize(Level5.width / scaleFactor  , Level5.height / scaleFactor);
		Level5.onTouchUpInside += sender => Application.LoadLevel("Level5");
		Level5.onTouchUpInside += sender => Basket.levelShortcutSet(0);
		Level6 = UIButton.create(buttonsManager,"L6.png","L6.png",0,0);
		Level6.setSize(Level6.width / scaleFactor  , Level6.height / scaleFactor);
		Level6.onTouchUpInside += sender => Application.LoadLevel("Level6");
		Level6.onTouchUpInside += sender => Basket.levelShortcutSet(0);
		Level7 = UIButton.create(buttonsManager,"L7.png","L7.png",0,0);
		Level7.setSize(Level7.width / scaleFactor  , Level7.height / scaleFactor);
		Level7.onTouchUpInside += sender => Application.LoadLevel("Level7");
		Level7.onTouchUpInside += sender => Basket.levelShortcutSet(0);
		Level8 = UIButton.create(buttonsManager,"L8.png","L8.png",0,0);
		Level8.setSize(Level8.width / scaleFactor  , Level8.height / scaleFactor);
		Level8.onTouchUpInside += sender => Application.LoadLevel("Level8");
		Level8.onTouchUpInside += sender => Basket.levelShortcutSet(0);
		Level9 = UIButton.create(buttonsManager,"L9.png","L9.png",0,0);
		Level9.setSize(Level9.width / scaleFactor  , Level9.height / scaleFactor);
		Level9.onTouchUpInside += sender => Application.LoadLevel("Level9");
		Level9.onTouchUpInside += sender => Basket.levelShortcutSet(0);
		Level10 = UIButton.create(buttonsManager,"L10.png","L10.png",0,0);
		Level10.setSize(Level10.width / scaleFactor  , Level10.height / scaleFactor);
		Level10.onTouchUpInside += sender => Application.LoadLevel("Level10");
		Level10.onTouchUpInside += sender => Basket.levelShortcutSet(0);

		Level1.positionFromCenter (-0.4f, 0f);
		Level2.parentUIObject = Level1;
		Level2.positionFromCenter (1.1f, 0f);
		Level3.parentUIObject = Level2;
		Level3.positionFromCenter (1.1f, 0f);
		Level4.parentUIObject = Level3;
		Level4.positionFromCenter (1.1f, 0f);
		Level5.parentUIObject = Level4;
		Level5.positionFromCenter (1.1f, 0f);
		Level6.parentUIObject = Level5;
		Level6.positionFromCenter (1.1f, 0f);
		Level7.parentUIObject = Level6;
		Level7.positionFromCenter (1.1f, 0f);
		Level8.parentUIObject = Level7;
		Level8.positionFromCenter (1.1f, 0f);
		Level9.parentUIObject = Level8;
		Level9.positionFromCenter (1.1f, 0f);
		Level10.parentUIObject = Level9;
		Level10.positionFromCenter (1.1f, 0f);

		Level1.touchDownSound = audioplay.getSoundClip ();
		Level2.touchDownSound = audioplay.getSoundClip ();
		Level3.touchDownSound = audioplay.getSoundClip ();
		Level4.touchDownSound = audioplay.getSoundClip ();
		Level5.touchDownSound = audioplay.getSoundClip ();
		Level6.touchDownSound = audioplay.getSoundClip ();
		Level7.touchDownSound = audioplay.getSoundClip ();
		Level8.touchDownSound = audioplay.getSoundClip ();
		Level9.touchDownSound = audioplay.getSoundClip ();
		Level10.touchDownSound = audioplay.getSoundClip ();


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
		}
	}
}
