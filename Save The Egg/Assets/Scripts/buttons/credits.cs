using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {
	
	public AudioClip Click;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var homeButton = UIButton.create("back_normal.png","back_active.png",0,0);
		homeButton.positionFromCenter( 0.18f, 0.07f );
		homeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		homeButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		homeButton.setSize(homeButton.width / scaleFactor,homeButton.height / scaleFactor);
		homeButton.touchDownSound = Click;

	}
	
	
}
