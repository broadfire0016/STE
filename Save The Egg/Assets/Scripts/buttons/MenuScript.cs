// Script attached to Main Menu UI, incharged of the buttons and state of sound and music in the game.
//Author: Aiza Aviso

using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	public GameObject TutorialEntrance, TutorialExit;
 	private AudioSource SoundSource;
 	private AudioSource MusicSource;
	private UIButton post, playButton, hidden, hidden1, collectionButton, storeButton, highScoreButton, creditsButton, help;
	private UIToggleButton sound, music; 
	int x=0;
	AudioScript audioplay;
	Animation obj;

	// Use this for initialization
	void Start () {
		audioplay = GameObject.FindGameObjectWithTag("SoundLoader").GetComponent<AudioScript>();

		if(AudioScript.status == false)
			audioplay.PlayMenuMusic();

		var scaleFactor = ScaleFactor.GetScaleFactor ();
		Time.timeScale = 1;
		print ("Width " + Screen.width + " Height " + Screen.height);

//main menu

		//play game
		playButton = UIButton.create("PlayBtn_normal.png","PlayBtn_active.png",0,0);
		playButton.setSize(playButton.width / scaleFactor  , playButton.height / scaleFactor);
		playButton.onTouchUpInside += sender => Application.LoadLevel("Loading");
		
		//view collections of toy darts
		collectionButton = UIButton.create("CollectionBtn_normal.png","CollectionBtn_active.png",0,0);
		collectionButton.onTouchUpInside += sender => Application.LoadLevel("collections");
		collectionButton.setSize(collectionButton.width/scaleFactor, collectionButton.height/scaleFactor);
		
		//store
		storeButton = UIButton.create("StoreBtn_normal.png","StoreBtn_active.png",0,0);
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");
		storeButton.setSize(storeButton.width/scaleFactor,storeButton.height/scaleFactor);

		//high score
		highScoreButton = UIButton.create("HighScoBtn_normal.png","HighScoBtn_active.png",0,0);
		highScoreButton.onTouchUpInside += sender => Application.LoadLevel("HS");;
		highScoreButton.setSize(highScoreButton.width/scaleFactor,highScoreButton.height/scaleFactor);

		//credits
		creditsButton = UIButton.create("CreditsBtn_normal.png","CreditsBtn_activel.png",0,0);
		creditsButton.onTouchUpInside += sender => Application.LoadLevel("credits");
		creditsButton.setSize(creditsButton.width/scaleFactor,creditsButton.height/scaleFactor);

		//post
		post = UIButton.create ("post.png", "post.png", 0, 0);
		post.setSize (post.width / scaleFactor, post.height / scaleFactor);

		//sound
		sound = UIToggleButton.create( "sound_normal.png","sound_mute.png","sound_active.png",0,0 );
		sound.onToggle += (sender,selected) => toggleSound(sender);
		sound.selected = false;
		sound.setSize(sound.width/scaleFactor, sound.height/scaleFactor);
		
		//music
		music = UIToggleButton.create( "music_normal.png","music_mute.png","music_active.png",0,0 );
		music.onToggle += (sender,selected) => toggleMusic(sender);
		music.selected = false;
		music.setSize(music.width/ scaleFactor,music.height / scaleFactor);

		help = UIButton.create("HelpBtn.png","HelpBtn.png",0,0);
		help.positionFromTopRight( 0f, -0.15f );
		help.onTouchUpInside += sender => x++;
		help.onTouchUpInside += sender => showTutorial();
		help.setSize(help.width/scaleFactor,help.height/scaleFactor);

		originalPosition ();
	}	

	void originalPosition(){
		music.positionFromBottomLeft (0.01f, 0.03f);
		sound.parentUIObject = music;
		sound.positionFromBottomLeft (0f,1.5f);
		playButton.parentUIObject = music;
		playButton.positionFromBottomLeft (9.35f, 0.6f);
		collectionButton.parentUIObject = playButton;
		collectionButton.positionFromBottomLeft(-0.65f, 0.12f);
		storeButton.parentUIObject = collectionButton;
		storeButton.positionFromBottomLeft(-1.0f, 0.00f);
		highScoreButton.parentUIObject = storeButton;
		highScoreButton.positionFromBottomLeft(-1.0f, 0.0f);
		creditsButton.parentUIObject = highScoreButton;
		creditsButton.positionFromBottomLeft(-1.0f, 0.0f);
		post.parentUIObject = creditsButton;
		post.positionFromBottomLeft (-1.1f, -0.3f);
	}

	void hidePos(){
		music.positionFromBottomLeft (9f, 9f);
		sound.parentUIObject = music;
		sound.positionFromBottomLeft (9f,9f);
		playButton.parentUIObject = music;
		playButton.positionFromBottomLeft (9f, 9f);
		collectionButton.parentUIObject = playButton;
		collectionButton.positionFromBottomLeft(9f, 9f);
		storeButton.parentUIObject = collectionButton;
		storeButton.positionFromBottomLeft(9f, 9f);
		highScoreButton.parentUIObject = storeButton;
		highScoreButton.positionFromBottomLeft(9f, 9f);
		creditsButton.parentUIObject = highScoreButton;
		creditsButton.positionFromBottomLeft(9f, 9f);
		post.parentUIObject = creditsButton;
		post.positionFromBottomLeft (9f, 9f);
	}

	void showTutorial(){
		if (x == 1) {
			TutorialEntrance.SetActive (true);
			hidePos();
		}
		if (x == 2) {
			x = 0;
			TutorialEntrance.SetActive(false);
			TutorialExit.SetActive(true);
			originalPosition();
			Invoke("DisableTutorial",1f);
		}	
	}

	void DisableTutorial(){
		TutorialExit.SetActive(false);
	}

	void Update(){
		playButton.touchDownSound = audioplay.getSoundClip();
		collectionButton.touchDownSound = audioplay.getSoundClip();
		storeButton.touchDownSound = audioplay.getSoundClip();
		highScoreButton.touchDownSound = audioplay.getSoundClip();
		creditsButton.touchDownSound = audioplay.getSoundClip();
		help.touchDownSound = audioplay.getSoundClip();
	}



 	void toggleSound(UIToggleButton sender){
		if (sender.selected)
			audioplay.setSoundMode(true);
		else
			audioplay.setSoundMode(false);
 	}

 	void toggleMusic(UIToggleButton sender){
		if (sender.selected)
			audioplay.setMusicMode(true);
		else
			audioplay.setMusicMode(false);
	}
}