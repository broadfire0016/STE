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
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		var storeButton = UIButton.create("store_normal.png","store_active.png",0,0);
		storeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		storeButton.touchDownSound = Click;
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");
	
#if UNITY_EDITOR || UNITY_IOS
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) { // iphone 4
			storeButton.positionFromBottomLeft( 0.11f, 0.50f );
			storeButton.setSize(storeButton.width / scaleFactor -15, storeButton.height / scaleFactor -8);
			backButton.setSize(backButton.width / scaleFactor +3, backButton.height / scaleFactor + 7);
			backButton.positionFromBottomLeft( 0.16f, 0.26f );
		}
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640 || Screen.width == 768 && Screen.height == 1024) { //ipad2
			storeButton.positionFromBottomLeft( 0.11f, 0.50f );
			storeButton.setSize(storeButton.width / scaleFactor -15, storeButton.height / scaleFactor -8);
			backButton.setSize(backButton.width / scaleFactor +3, backButton.height / scaleFactor + 7);
			backButton.positionFromBottomLeft( 0.153f, 0.26f );
		}
		if (Screen.width == 1536 && Screen.height == 2048){ //Ipad4
			storeButton.positionFromBottomLeft( 0.11f, 0.50f );
			storeButton.setSize(storeButton.width / scaleFactor -15, storeButton.height / scaleFactor -8);
			backButton.setSize(backButton.width / scaleFactor +3, backButton.height / scaleFactor + 7);
			backButton.positionFromBottomLeft( 0.153f, 0.26f );
		}
		if (Screen.width == 411 && Screen.height == 730 ||Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136){
			storeButton.positionFromBottomLeft( 0.11f, 0.50f );
			storeButton.setSize(storeButton.width / scaleFactor -15, storeButton.height / scaleFactor -8);
			backButton.setSize(backButton.width / scaleFactor +3, backButton.height / scaleFactor + 7);
			backButton.positionFromBottomLeft( 0.17f, 0.26f );
			background.transform.localScale = new Vector3(0.4546752f,background.transform.localScale.y,background.transform.localScale.z);
		}	
#endif
	
	}
	
	
}
