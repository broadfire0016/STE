//Store Button Script
//author - Aiza

using UnityEngine;
using System.Collections;

public class gameStore : MonoBehaviour {
	public AudioClip Click;
	public UIToolkit backManager;
	public GameObject background;
	public UIToolkit storeManager;
	AudioScript audioplay;

	void Awake(){
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
	}
	
	//game store
	void Start () {
		AudioScript.status = true;
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		var backButton = UIButton.create(backManager, "back_normal2.png","back_active2.png",0,0);
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = audioplay.getSoundClip();
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		backButton.positionFromCenter( 0.43f, 0.05f );
		backButton.setSize(backButton.width / scaleFactor * 1f, backButton.height / scaleFactor * 1f);

		var scrollable = new UIScrollableVerticalLayout( 10 );
		scrollable.alignMode = UIAbstractContainer.UIContainerAlignMode.Center;
		scrollable.parentUIObject = backButton;
		scrollable.positionFromCenter( -12.5f, -2.2f );
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
