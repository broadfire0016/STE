//Credits Scene Script
//author: Aiza

using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {
	
	public AudioClip Click;
	public UIToolkit creditsManager;
	public GameObject background;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var CloseBtn = UIButton.create(creditsManager,"back_normal2.png","back_active2.png",0,0);
		CloseBtn.userData = "Click";
		CloseBtn.highlightedTouchOffsets = new UIEdgeOffsets(30);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.touchDownSound = Click;

#if UNITY_EDITOR || UNITY_IOS
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) { // iphone 4
			CloseBtn.positionFromBottomRight( 0.25f, 0.27f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor +20, CloseBtn.height / scaleFactor +15);
		}
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640 || Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) { //ipad
			CloseBtn.positionFromBottomRight( 0.25f, 0.3f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}
		if (Screen.width == 411 && Screen.height == 730 ||Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136){
			CloseBtn.positionFromBottomRight( 0.25f, 0.20f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor + 20, CloseBtn.height / scaleFactor + 15);
			background.transform.localScale = new Vector3(0.4092509f,background.transform.localScale.y,background.transform.localScale.z);
		}	
#endif
	}
}
