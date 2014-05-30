//High Score Button Script
//author: Levi

using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	public UIToolkit highscoreManager;
	public AudioClip Click;
	public GameObject background;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//high score
		var CloseBtn = UIButton.create(highscoreManager,"back_normal2.png","back_active2.png",0,0);
		CloseBtn.userData = "Click";
		CloseBtn.highlightedTouchOffsets = new UIEdgeOffsets(30);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.touchDownSound = Click;
		CloseBtn.positionFromBottomLeft( 0.23f, 0.3f );
		CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);

	}
	
}
