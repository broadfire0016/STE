using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	public UIToolkit highscoreManager;
	public AudioClip Click;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//high score
		var CloseBtn = UIButton.create(highscoreManager,"back_normal2.png","back_active2.png",0,0);
		CloseBtn.userData = "Click";
		CloseBtn.highlightedTouchOffsets = new UIEdgeOffsets(30);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.touchDownSound = Click;

#if UNITY_EDITOR
		if (Screen.width == 487 && Screen.height == 730) { // iphone 4
			CloseBtn.positionFromBottomRight( 0.23f, 0.27f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor +20, CloseBtn.height / scaleFactor +15);
		}
		if (Screen.width == 548 && Screen.height == 730) { //ipad
			CloseBtn.positionFromBottomRight( 0.23f, 0.3f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}
		if (Screen.width == 411 && Screen.height == 730){ //iphone 5
			CloseBtn.positionFromBottomRight( 0.23f, 0.20f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor + 20, CloseBtn.height / scaleFactor + 15);
		}	
		#endif
		
#if UNITY_IOS
		if (Screen.width == 640 && Screen.height == 960) { // iphone4
			CloseBtn.positionFromBottomRight( 0.23f, 0.074f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}
		if (Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) { //ipad
			CloseBtn.positionFromBottomRight( 0.23f, 0.074f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}
		
		if (Screen.width == 640 && Screen.height == 1136){ //iphone 5
			CloseBtn.positionFromBottomRight( 0.23f, 0.074f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}	
#endif	
	}
	
}
