using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	public UIToolkit highscoreManager;
	public AudioClip Click;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//high score
		var CloseBtn = UIButton.create(highscoreManager,"CloseBtn.png","CloseBtn.png",0,0);
		CloseBtn.positionFromTopRight( 0.26f, 0.074f );
		CloseBtn.userData = "Click";
		CloseBtn.highlightedTouchOffsets = new UIEdgeOffsets(30);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		CloseBtn.touchDownSound = Click;

		CloseBtn.onTouchUp += OnButtonUp;
		CloseBtn.onTouchDown += OnButtonDown;
		CloseBtn.onTouchUpInside += OnButtonSelect;
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
