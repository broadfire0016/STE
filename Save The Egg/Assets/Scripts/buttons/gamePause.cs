using UnityEngine;
using System.Collections;

public class gamePause : MonoBehaviour {
	public AudioClip Click;
	
	// Use this for initialization
	void Start () {
			
		var replayButton = UIButton.create( "resume_normal.png", "resume_active.png", 0, 0 );
        replayButton.positionFromTopLeft( 0.47f, 0.22f );
		replayButton.highlightedTouchOffsets = new UIEdgeOffsets( 30 );
		replayButton.onTouchUpInside += ( sender ) => Debug.Log( "clicked the button: " + sender );
		replayButton.touchDownSound = Click;
		replayButton.setSize(85f,80f);
		
		var resumeButton = UIButton.create( "play_normal2.png", "play_active.png", 0, 0 );
        resumeButton.positionFromTopLeft( 0.47f, 0.42f );
		resumeButton.highlightedTouchOffsets = new UIEdgeOffsets( 30 );
		resumeButton.onTouchUpInside += ( sender ) => Application.LoadLevel("Level1");
		resumeButton.touchDownSound = Click;
		resumeButton.setSize(85f,80f);
		
		var menuButton = UIButton.create( "home_normal.png", "home_active.png", 0, 0 );
        menuButton.positionFromTopLeft( 0.47f, 0.63f );
		menuButton.highlightedTouchOffsets = new UIEdgeOffsets( 30 );
		menuButton.onTouchUpInside += ( sender ) => Application.LoadLevel("AGAIN");
		menuButton.touchDownSound = Click;
		menuButton.setSize(85f,80f);
	}
	
}
