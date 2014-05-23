using UnityEngine;
using System.Collections;

public class collections : MonoBehaviour {
public AudioClip Click;

	// Use this for initialization
	void Start () {

		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//game collection
		var backButton = UIButton.create("back_normal.png","back_active.png",0,0);
		backButton.positionFromCenter( 0.42f, 0.05f );
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.setSize(backButton.width / scaleFactor, backButton.height / scaleFactor);
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
	}
	
	
}
