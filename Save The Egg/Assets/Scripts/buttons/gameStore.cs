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
		}
}
