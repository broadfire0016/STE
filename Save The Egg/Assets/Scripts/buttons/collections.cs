using UnityEngine;
using System.Collections;

public class collections : MonoBehaviour {
public AudioClip Click;

	// Use this for initialization
	void Start () {

		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//game collection
		var backButton = UIButton.create("back_normal.png","back_active.png",0,0);
		backButton.positionFromCenter( 0.33f, -0.08f );
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.setSize(backButton.width / scaleFactor, backButton.height / scaleFactor);
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");

		var storeButton = UIButton.create("store_normal.png","store_active.png",0,0);
		storeButton.positionFromCenter( 0.34f, 0.2f );
		storeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		storeButton.touchDownSound = Click;
		storeButton.setSize(storeButton.width / scaleFactor -15, storeButton.height / scaleFactor -8);
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");
	}
	
	
}
