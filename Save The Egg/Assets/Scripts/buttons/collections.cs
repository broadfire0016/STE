using UnityEngine;
using System.Collections;

public class collections : MonoBehaviour {
public AudioClip Click;

	// Use this for initialization
	void Start () {

		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//game collection
		var backButton = UIButton.create("back_normal2.png","back_active2.png",0,0);
		backButton.positionFromBottomLeft( 0.14f, 0.26f );
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.setSize(backButton.width / scaleFactor +3, backButton.height / scaleFactor + 7);
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");

		var storeButton = UIButton.create("store_normal.png","store_active.png",0,0);
		storeButton.positionFromBottomLeft( 0.11f, 0.50f );
		storeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		storeButton.touchDownSound = Click;
		storeButton.setSize(storeButton.width / scaleFactor -15, storeButton.height / scaleFactor -8);
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");
	}
	
	
}
