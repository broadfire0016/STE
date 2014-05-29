using UnityEngine;
using System.Collections;

public class gameStore : MonoBehaviour {
	public AudioClip Click;
	public UIToolkit backManager;
	public GameObject background;
	
	//game store
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		var backButton = UIButton.create(backManager, "back_normal2.png","back_active2.png",0,0);
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");


#if UNITY_EDITOR || UNITY_IOS
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) { // iphone 4
			backButton.positionFromBottomLeft( 0.08f, 0.40f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
		}
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640 || Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048 ) { //ipad
			backButton.positionFromBottomLeft( 0.08f, 0.42f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
		}
		if (Screen.width == 411 && Screen.height == 730 ||Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136 ){ //iphone 5
			backButton.positionFromBottomLeft( 0.08f, 0.40f );
			backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);
			background.transform.localScale = new Vector3(0.8375f,background.transform.localScale.y,background.transform.localScale.z);
			background.transform.position = new Vector3(1.437335f,background.transform.position.y,background.transform.position.z);
		}	
#endif

	}
}
