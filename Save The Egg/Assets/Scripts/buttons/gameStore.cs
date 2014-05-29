using UnityEngine;
using System.Collections;

public class gameStore : MonoBehaviour {
	public AudioClip Click;
	public UIToolkit backManager;
	
	//game store
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		var backButton = UIButton.create(backManager, "back_normal2.png","back_active2.png",0,0);
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");


#if UNITY_EDITOR
		if (Screen.width == 487 && Screen.height == 730) { // iphone 4
			backButton.positionFromBottomLeft( 0.08f, 0.42f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
		}
		if (Screen.width == 548 && Screen.height == 730) { //ipad
			backButton.positionFromBottomLeft( 0.08f, 0.42f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
		}
		if (Screen.width == 411 && Screen.height == 730){ //iphone 5
			backButton.positionFromBottomLeft( 0.08f, 0.42f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
		}	
		#endif
		
#if UNITY_IOS
		if (Screen.width == 640 && Screen.height == 960) { // iphone4
			backButton.positionFromBottomLeft( 0.08f, 0.42f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
		}
		if (Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) { //ipad
			backButton.positionFromBottomLeft( 0.08f, 0.42f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
		}
		
		if (Screen.width == 640 && Screen.height == 1136){ //iphone 5
			backButton.positionFromBottomLeft( 0.08f, 0.42f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
		}	
#endif	

		}
}
