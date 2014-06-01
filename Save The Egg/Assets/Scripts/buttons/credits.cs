//Credits Scene Script
//author: Aiza

using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {
	
	public AudioClip Click;
	public UIToolkit creditsManager;
	public GameObject background;
	AudioScript audioplay;
	
	void Awake(){
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
	}
	// Use this for initialization
	void Start () {
		//var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home
		var CloseBtn = UIButton.create(creditsManager,"back_normal2.png","back_active2.png",0,0);
		CloseBtn.userData = "Click";
		CloseBtn.positionFromCenter( 0.17f, 0.02f );
		CloseBtn.highlightedTouchOffsets = new UIEdgeOffsets(30);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.touchDownSound = audioplay.getSoundClip();
	}
}
