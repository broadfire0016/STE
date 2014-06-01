//Store Button Script
//author - Aiza

using UnityEngine;
using System.Collections;

public class gameStore : MonoBehaviour {
	public AudioClip Click;
	public UIToolkit backManager;
	public GameObject background;
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
		backButton.positionFromBottomLeft( 0.02f, 0.42f );
		backButton.setSize(backButton.width / scaleFactor +20, backButton.height / scaleFactor +15);

	}
}
