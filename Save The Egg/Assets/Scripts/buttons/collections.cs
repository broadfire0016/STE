//Collections Scene Script
//author Aiza

using UnityEngine;
using System.Collections;

public class collections : MonoBehaviour {
public GameObject background;
AudioScript audioplay;
	
	void Awake(){
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
	}
	
	// Use this for initialization
	void Start () {
		print ("Width " + Screen.width + " Height " + Screen.height);
		var scaleFactor = ScaleFactor.GetScaleFactor ();
	//game collection
		var backButton = UIButton.create("back_normal2.png","back_active2.png",0,0);
		backButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		backButton.touchDownSound = audioplay.getSoundClip();;
		backButton.setSize(backButton.width / scaleFactor +6, backButton.height / scaleFactor + 11);
		backButton.onTouchUpInside += sender => Application.LoadLevel("AGAIN");

		var storeButton = UIButton.create("store_normal.png","store_active.png",0,0);
		storeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		storeButton.touchDownSound = audioplay.getSoundClip();;
		storeButton.setSize(storeButton.width / scaleFactor, storeButton.height / scaleFactor *0.98f );
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");	

		backButton.positionFromBottomLeft( 0.155f, 0.23f );
		storeButton.parentUIObject = backButton;
		storeButton.positionFromBottomLeft( 0f, 1.3f);
	}	
}
