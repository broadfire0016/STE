using UnityEngine;
using System.Collections;

public class gameStore : MonoBehaviour {
	public AudioClip Click;
	public UIToolkit backManager;
	
	//game store
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		var backButton = UIButton.create(backManager, "back_normal2.png","back_active2.png",0,0);
		backButton.positionFromBottomLeft( 0.08f, 0.42f );
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.setSize(backButton.width / scaleFactor, backButton.height / scaleFactor);
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");


#if UNITY_EDITOR
		if (Screen.width == 487 && Screen.height == 730) { // iphone 4

		}
		if (Screen.width == 548 && Screen.height == 730) { //ipad

		}
		if (Screen.width == 411 && Screen.height == 730){ //iphone 5

		}	
		#endif
		
		#if UNITY_IOS
		if (Screen.width == 640 && Screen.height == 960) { // iphone4

		}
		if (Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) { //ipad

		}
		
		if (Screen.width == 640 && Screen.height == 1136){ //iphone 5

		}	
#endif	

		}
}
