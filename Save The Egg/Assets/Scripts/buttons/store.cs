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
		scrollable.position = new Vector3( 35, -150, 0 );
		scrollable.setSize( Screen.width/1.1f, Screen.height / 1.7f );


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