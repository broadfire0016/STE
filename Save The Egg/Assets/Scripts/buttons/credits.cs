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
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//home

		var source = UIButton.create(creditsManager,"back_normal2.png","back_active2.png",0,0);
		source.setSize(source.width/scaleFactor,source.height/scaleFactor);
		source.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		source.touchDownSound = audioplay.getSoundClip();


		var CloseBtn = UIButton.create(creditsManager,"back_normal2.png","back_active2.png",0,0);
		CloseBtn.userData = "Click";
		CloseBtn.setSize(CloseBtn.width/scaleFactor,CloseBtn.height/scaleFactor);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.touchDownSound = audioplay.getSoundClip();

		source.positionFromCenter( 0.6f, 0.0f );
		CloseBtn.parentUIObject = source;
		CloseBtn.positionFromCenter( -8f, 0.0f );

		
	}
}
