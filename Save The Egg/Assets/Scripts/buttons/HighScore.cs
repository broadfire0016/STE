using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	public UIToolkit buttonsManager;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//high score
		var backButton = UIButton.create(buttonsManager,"back_normal.png","back_active.png",0,0);
		backButton.positionFromCenter( 0.22f, 0.060f );
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		backButton.setSize(backButton.width / scaleFactor,backButton.height / scaleFactor);
	}
	
}
