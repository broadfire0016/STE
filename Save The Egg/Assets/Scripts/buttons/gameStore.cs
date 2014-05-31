//Store Button Script
//author - Aiza

using UnityEngine;
using System.Collections;

public class gameStore : MonoBehaviour {
	public AudioClip Click;
	public UIToolkit backManager;
	public GameObject background;
	
	//game store
	void Start () {
		AudioScript.status = true;
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		var backButton = UIButton.create(backManager, "back_normal2.png","back_active2.png",0,0);
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = Click;
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		backButton.positionFromBottomLeft( 0.08f, 0.42f );
		backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);

	}
}
