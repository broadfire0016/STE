//Store Script. Show different menus
//author: Aiza Aviso & Levi Lim

using UnityEngine;
using System.Collections;

public class store : MonoBehaviour
{
	private bool _movedContainepublic;
	public UIToolkit storeManager;
	
	//public UIToolkit textManager;

	void Start()
	{
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		var scrollable = new UIScrollableVerticalLayout( 10 );
		scrollable.alignMode = UIAbstractContainer.UIContainerAlignMode.Center;
		

#if UNITY_EDITOR || UNITY_IOS
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) { // iphone 4
			scrollable.position = new Vector3( 35, -150, 0 );
			scrollable.setSize( Screen.width/1.1f, Screen.height / 1.7f );
		}
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640 || Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) { //ipad
			scrollable.position = new Vector3( 35, -150, 0 );
			scrollable.setSize( Screen.width/1.1f, Screen.height / 1.7f );
		}
		if (Screen.width == 411 && Screen.height == 730 ||Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136){ //iphone 5
			scrollable.position = new Vector3( 35, -150, 0 );
			scrollable.setSize( Screen.width/1.1f, Screen.height / 1.7f );
		}	
#endif

		for( var i = 0; i < 15; i++ )
		{
			UIButton touchable;
			if( i == 4 ) // text sprite
			{
				touchable = UIButton.create(storeManager, "4.png", "4.png", 0, 0 );
				touchable.setSize(touchable.width/ scaleFactor - 50f, touchable.height / scaleFactor - 20f);
				touchable.userData = "Click";
				touchable.onTouchUpInside += (sender) => Application.LoadLevel("shortcuts");
				touchable.onTouchUp += OnButtonUp;
				touchable.onTouchDown += OnButtonDown;
				touchable.onTouchUpInside += OnButtonSelect;
				touchable.parentUIObject = scrollable;
			}
			else if( i % 3 == 0 )
			{
				touchable = UIButton.create( "3.png", "3.png", 0, 0 );
				touchable.setSize(touchable.width/ scaleFactor - 50f, touchable.height / scaleFactor - 20f);
				touchable.onTouchUpInside += (sender) => Application.LoadLevel("shortcuts");
				touchable.onTouchUp += OnButtonUp;
				touchable.onTouchDown += OnButtonDown;
				touchable.onTouchUpInside += OnButtonSelect;
				touchable.parentUIObject = scrollable;
			}
			else if( i % 2 == 0 )
			{
				touchable = UIButton.create( "2.png", "2.png", 0, 0 );
				touchable.setSize(touchable.width/ scaleFactor - 50f, touchable.height / scaleFactor - 20f);
				touchable.onTouchUpInside += (sender) => Application.LoadLevel("shortcuts");
				touchable.onTouchUp += OnButtonUp;
				touchable.onTouchDown += OnButtonDown;
				touchable.onTouchUpInside += OnButtonSelect;
				touchable.parentUIObject = scrollable;
			}
			else
			{
				touchable = UIButton.create( "1.png", "1.png", 0, 0 );
				touchable.setSize(touchable.width/ scaleFactor - 50f, touchable.height / scaleFactor - 20f);
				touchable.onTouchUpInside += (sender) => Application.LoadLevel("shortcuts");
				touchable.onTouchUp += OnButtonUp;
				touchable.onTouchDown += OnButtonDown;
				touchable.onTouchUpInside += OnButtonSelect;
				touchable.parentUIObject = scrollable;
			}
			scrollable.addChild( touchable );
		}
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