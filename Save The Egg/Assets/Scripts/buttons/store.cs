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
		scrollable.position = new Vector3( 0, -110, 0 );
		//var width = UI.scaleFactor * 20;
		//var height = UI.scaleFactor * 50;
		//scrollable.setSize(scrollable.width/ scaleFactor - 100f, scrollable.height / scaleFactor - 50f);
		scrollable.setSize( Screen.width/1.1f, Screen.height / 1.4f );

/*
		var dart1 = UIButton.create (storeManager, "4.png", "4.png", 0, 0);
		dart1.setSize (dart1.width / scaleFactor, dart1.height / scaleFactor);
		dart1.positionFromBottomLeft (0.1f, 0.01f);
		dart1.userData = "Click";
		dart1.onTouchUp += OnButtonUp;
		dart1.onTouchDown += OnButtonDown;
		dart1.onTouchUpInside += OnButtonSelect;
		dart1.parentUIObject = scrollable;
		*/

		for( var i = 0; i < 15; i++ )
		{
			UIButton touchable;
			if( i == 4 ) // text sprite
			{
				touchable = UIButton.create(storeManager, "4.png", "4.png", 0, 0 );
				touchable.setSize(touchable.width/ scaleFactor - 50f, touchable.height / scaleFactor - 20f);
				touchable.userData = "Click";
				//touchable.onTouchUpInside += (sender) => Application.LoadLevel("collections");
				touchable.onTouchUp += OnButtonUp;
				touchable.onTouchDown += OnButtonDown;
				touchable.onTouchUpInside += OnButtonSelect;
				touchable.parentUIObject = scrollable;
			}
			else if( i % 3 == 0 )
			{
				touchable = UIButton.create( "3.png", "3.png", 0, 0 );
				touchable.setSize(touchable.width/ scaleFactor - 50f, touchable.height / scaleFactor - 20f);
				touchable.onTouchUp += OnButtonUp;
				touchable.onTouchDown += OnButtonDown;
				touchable.onTouchUpInside += OnButtonSelect;
				touchable.parentUIObject = scrollable;
			}
			else if( i % 2 == 0 )
			{
				touchable = UIButton.create( "2.png", "2.png", 0, 0 );
				touchable.setSize(touchable.width/ scaleFactor - 50f, touchable.height / scaleFactor - 20f);
				touchable.onTouchUp += OnButtonUp;
				touchable.onTouchDown += OnButtonDown;
				touchable.onTouchUpInside += OnButtonSelect;
				touchable.parentUIObject = scrollable;
			}
			else
			{
				touchable = UIButton.create( "1.png", "1.png", 0, 0 );
				touchable.setSize(touchable.width/ scaleFactor - 50f, touchable.height / scaleFactor - 20f);
				touchable.onTouchUp += OnButtonUp;
				touchable.onTouchDown += OnButtonDown;
				touchable.onTouchUpInside += OnButtonSelect;
				touchable.parentUIObject = scrollable;
			}
			
			/*
			// extra flair added by putting some child objects in some of the buttons created above
			if( i == 1 )
			{
				// add a toggle button to the first element in the list
				var ch = UIToggleButton.create( "cbUnchecked.png", "cbChecked.png", "cbDown.png", 0, 0 );
				ch.parentUIObject = touchable;
				ch.pixelsFromRight( 0 );
				ch.client.name = "TEST THINGY";
				ch.scale = new Vector3( 0.5f, 0.5f, 1 );
			}
			else if( i == 4 )
			{
				// add some text to the 4th element in the list
				var text = new UIText( textManager, "prototype", "prototype.png" );

				var helloText = text.addTextInstance( "Child Text", 0, 0, 0.5f, -1, Color.black, UITextAlignMode.Center, UITextVerticalAlignMode.Middle );
				helloText.parentUIObject = touchable;
				helloText.positionCenter();
				
				// add a scaled down toggle button as well but this will be parented to the text
				var ch = UIToggleButton.create( "cbUnchecked.png", "cbChecked.png", "cbDown.png", 0, 0 );
				ch.parentUIObject = helloText;
				ch.pixelsFromRight( -16 );
				ch.client.name = "subsub";
				ch.scale = new Vector3( 0.25f, 0.25f, 0 );
			}

			
			// only add a touchUpInside handler for buttons
			if( touchable is UIButton )
			{
				var button = touchable as UIButton;
				
				// store i locally so we can put it in the closure scope of the touch handler
				var j = i;
				button.onTouchUpInside += ( sender ) => Debug.Log( "touched button: " + j );
			}*/
			

			scrollable.addChild( touchable );
		}
		
		/*
		// click to scroll to a specific offset
		var UpBtn = UIButton.create( "up_normal.png", "up_active.png", 0, 0 );
		UpBtn.positionFromTopRight( 0, 0 );
		UpBtn.highlightedTouchOffsets = new UIEdgeOffsets( 30 );
		UpBtn.onTouchUpInside += ( sender ) =>
		{
			scrollable.scrollTo( -10, true );
		};
		
		
		scores = UIButton.create( "scoresUp.png", "scoresDown.png", 0, 0 );
		scores.positionFromBottomRight( 0, 0 );
		scores.highlightedTouchOffsets = new UIEdgeOffsets( 30 );
		scores.onTouchUpInside += ( sender ) =>
		{
			scrollable.scrollTo( -600, true );
		};
		
		
		scores = UIButton.create( "scoresUp.png", "scoresDown.png", 0, 0 );
		scores.centerize();
		scores.positionFromTopRight( 0.5f, 0 );
		scores.highlightedTouchOffsets = new UIEdgeOffsets( 30 );
		scores.onTouchUpInside += ( sender ) =>
		{
			var target = scrollable.position;
			var moveBy = _movedContainer ? -50 : 50;
			moveBy *= UI.scaleFactor;
			target.x += moveBy * 2;
			target.y += moveBy;
			scrollable.positionTo( 0.4f, target, Easing.Quintic.easeIn );
			_movedContainer = !_movedContainer;
		};
		*/
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
	}}

}