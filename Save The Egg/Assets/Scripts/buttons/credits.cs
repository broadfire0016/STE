using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {
	
	public AudioClip Click;
	public UIToolkit creditsManager;
	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var CloseBtn = UIButton.create(creditsManager,"CloseBtn.png","CloseBtn.png",0,0);
		CloseBtn.userData = "Click";
		CloseBtn.highlightedTouchOffsets = new UIEdgeOffsets(30);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.touchDownSound = Click;

		CloseBtn.onTouchUp += OnButtonUp;
		CloseBtn.onTouchDown += OnButtonDown;
		CloseBtn.onTouchUpInside += OnButtonSelect;


		#if UNITY_EDITOR
		if (Screen.width == 487 && Screen.height == 730) { // iphone 4
			CloseBtn.positionFromTopRight( 0.260f, 0.01f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}
		if (Screen.width == 548 && Screen.height == 730) { //ipad
			CloseBtn.positionFromTopRight( 0.245f, 0.05f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}
		if (Screen.width == 411 && Screen.height == 730){ //iphone 5
			CloseBtn.positionFromTopRight( 0.261f, - 0.05f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}	
		#endif
		
#if UNITY_IOS
		if (Screen.width == 640 && Screen.height == 960) { // iphone4
			CloseBtn.positionFromTopRight( 0.245f, 0.05f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}
		if (Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) { //ipad
			CloseBtn.positionFromTopRight( 0.245f, 0.05f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}
		
		if (Screen.width == 640 && Screen.height == 1136){ //iphone 5
			CloseBtn.positionFromTopRight( 0.245f, 0.05f );
			CloseBtn.setSize(CloseBtn.width / scaleFactor, CloseBtn.height / scaleFactor);
		}	
#endif	
}

	
	void OnButtonDown(UIButton obj){
		obj.scale = new Vector3 (1.1f, 1.1f, 1.1f);
	}

	void OnButtonUp(UIButton obj){
		obj.scale = new Vector3 (1f, 1f, 1f);
	}	

	void OnButtonSelect(UIButton obj){
		string btn = (string)obj.userData;
		switch (btn){
			case "Click":
		
		break;
		}
	}
	
}
