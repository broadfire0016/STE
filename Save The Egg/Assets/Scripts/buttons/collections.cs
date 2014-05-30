//Collections Scene Script
//author Aiza

using UnityEngine;
using System.Collections;

public class collections : MonoBehaviour {
public AudioClip Click;
public GameObject background;

	// Use this for initialization
	void Start () {
		print ("Width " + Screen.width + " Height " + Screen.height);
		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//game collection
		var backButton = UIButton.create("back_normal2.png","back_active2.png",0,0);
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.setSize(backButton.width / scaleFactor +3, backButton.height / scaleFactor + 7);
		backButton.positionFromBottomLeft( 0.153f, 0.26f );
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		var storeButton = UIButton.create("store_normal.png","store_active.png",0,0);
		storeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		storeButton.touchDownSound = Click;
		storeButton.positionFromBottomLeft( 0.11f, 0.50f );
		storeButton.setSize(storeButton.width / scaleFactor -15, storeButton.height / scaleFactor -8);
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");	
	}	
}
