﻿//High Score Button Script
//author: Levi

using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	public UIToolkit highscoreManager;
	public AudioClip Click;
	public GameObject background;
	private int highScore;
	private UITextInstance highscoretext;
	private UIText highScoreText;
	public UIToolkit textManager;
	
	AudioScript audioplay;
	
	void Awake(){
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();
	}

	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		//high score
		var CloseBtn = UIButton.create(highscoreManager,"back_normal2.png","back_active2.png",0,0);
		CloseBtn.highlightedTouchOffsets = new UIEdgeOffsets(30);
		CloseBtn.onTouchUpInside += sender => Application.LoadLevel("AGAIN");
		CloseBtn.touchDownSound = audioplay.getSoundClip();
		CloseBtn.positionFromBottomLeft( 0.23f, 0.35f );
		CloseBtn.setSize(CloseBtn.width / scaleFactor +50, CloseBtn.height / scaleFactor + 25);

		highScore = Main.getHighScore();
		highScoreText = new UIText(textManager, "VogueCyrBold_60_ffffff", "VogueCyrBold_60_ffffff.png");
		highscoretext = highScoreText.addTextInstance(string.Format("{0}", highScore), 0, 0 );
		highscoretext.textScale = 2f;
		highscoretext.positionFromCenter(0.0f, 0.01f);
		highscoretext.color = Color.black;
		
	}
	
}
