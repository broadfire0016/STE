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
		//var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var CloseBtn = UIButton.create(creditsManager,"back_normal2.png","back_active2.png",0,0);
		CloseBtn.userData = "Click";
		CloseBtn.positionFromBottomLeft( 0.25f, 0.3f );
		CloseBtn.highlightedTouchOffsets = new UIEdgeOffsets(30);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.touchDownSound = Click;
	}
}
