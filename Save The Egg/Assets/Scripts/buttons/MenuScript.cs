// Script attached to Main Menu UI, incharged of the buttons and state of sound and music in the game.
//Author: Aiza Aviso

using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	public AudioClip Click;
 	private AudioSource SoundSource;
 	private AudioSource MusicSource;
	private UIButton post, playButton, collectionButton, storeButton, highScoreButton, creditsButton;
	private UIToggleButton sound, music; 

	// Use this for initialization
	void Start () {
		var scaleFactor = ScaleFactor.GetScaleFactor ();
		Time.timeScale = 1;
		print ("Width " + Screen.width + " Height " + Screen.height);

		//main menu

		//post
		post = UIButton.create ("post.png", "post.png", 0, 0);
		post.setSize (post.width / scaleFactor, post.height / scaleFactor);
		post.userData = "post";
	
		//play game
		playButton = UIButton.create("PlayBtn_normal.png","PlayBtn_active.png",0,0);
		playButton.touchDownSound = Click;
		playButton.setSize(playButton.width/ scaleFactor , playButton.height / scaleFactor);
		playButton.onTouchUpInside += sender => Application.LoadLevel("Loading");
		
		//view collections of toy darts
		collectionButton = UIButton.create("CollectionBtn_normal.png","CollectionBtn_active.png",0,0);
		//collectionButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		collectionButton.onTouchUpInside += sender => Application.LoadLevel("collections");
		collectionButton.touchDownSound = Click;
		collectionButton.setSize(collectionButton.width/scaleFactor, collectionButton.height/scaleFactor);
		
		//store
		storeButton = UIButton.create("StoreBtn_normal.png","StoreBtn_active.png",0,0);
		//storeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");
		storeButton.touchDownSound = Click;
		storeButton.setSize(storeButton.width/scaleFactor,storeButton.height/scaleFactor);
		
		//high score
		highScoreButton = UIButton.create("HighScoBtn_normal.png","HighScoBtn_active.png",0,0);
		//highScoreButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		highScoreButton.onTouchUpInside += sender => Application.LoadLevel("HS");
		highScoreButton.touchDownSound = Click;
		highScoreButton.setSize(highScoreButton.width/scaleFactor,highScoreButton.height/scaleFactor);
		
		//credits
		creditsButton = UIButton.create("CreditsBtn_normal.png","CreditsBtn_activel.png",0,0);
		creditsButton.onTouchUpInside += sender => Application.LoadLevel("credits");
		creditsButton.touchDownSound = Click;
		creditsButton.setSize(creditsButton.width/scaleFactor,creditsButton.height/scaleFactor);

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

#if UNITY_EDITOR || UNITY_IOS
		//Iphone 4
		if (Screen.width == 487 && Screen.height == 730 || Screen.width == 427 && Screen.height == 640 || Screen.width == 640 && Screen.height == 960) {
			post.positionFromTopLeft (0.48f, 0.10f);
			playButton.positionFromTopLeft (0.55f, 0.13f);
			collectionButton.positionFromTopLeft( 0.62f, 0.17f );
			storeButton.positionFromTopLeft( 0.67f, 0.17f );
			highScoreButton.positionFromTopLeft( 0.72f, 0.17f );
			creditsButton.positionFromTopLeft( 0.77f, 0.17f );
			sound.positionFromBottomLeft( 0.015f, 0.024f );
			music.positionFromBottomLeft( 0.015f, 0.25f );
		}
		//Ipad2 and Ipad4
		if (Screen.width == 548 && Screen.height == 730 || Screen.width == 480 && Screen.height == 640 || Screen.width == 768 && Screen.height == 1024 || Screen.width == 1536 && Screen.height == 2048) {
			post.positionFromTopLeft (0.48f, 0.10f);
			playButton.positionFromTopLeft (0.56f, 0.13f);
			collectionButton.positionFromTopLeft( 0.64f, 0.17f );
			storeButton.positionFromTopLeft( 0.695f, 0.17f );
			highScoreButton.positionFromTopLeft( 0.75f, 0.17f );
			creditsButton.positionFromTopLeft( 0.805f, 0.17f );
			sound.positionFromBottomLeft( 0.015f, 0.024f );
			music.positionFromBottomLeft( 0.015f, 0.25f );
		}
		//Iphone 5
		if (Screen.width == 411 && Screen.height == 730 ||Screen.width == 360 && Screen.height == 640 || Screen.width == 640 && Screen.height == 1136){
			post.positionFromTopLeft (0.48f, 0.08f);
			playButton.positionFromTopLeft (0.54f, 0.10f);
			collectionButton.positionFromTopLeft( 0.60f, 0.14f );
			storeButton.positionFromTopLeft( 0.64f, 0.14f );
			highScoreButton.positionFromTopLeft( 0.68f, 0.14f );
			creditsButton.positionFromTopLeft( 0.72f, 0.14f );
			sound.positionFromBottomLeft( 0.02f, 0.024f );
			music.positionFromBottomLeft( 0.02f, 0.25f );
		}
#endif
	}	

	void Update(){
		if (AudioScript.getSoundMode()== true){
		   	playButton.touchDownSound = null;
		   	collectionButton.touchDownSound = null;
			storeButton.touchDownSound = null;
			highScoreButton.touchDownSound = null;
			creditsButton.touchDownSound = null;
		 }
		 else{
			playButton.touchDownSound = Click;
			collectionButton.touchDownSound = Click;
			storeButton.touchDownSound = Click;
			highScoreButton.touchDownSound = Click;
			creditsButton.touchDownSound = Click;
		 }
 	}

 	void toggleSound(UIToggleButton sender){
		if (sender.selected){
			AudioScript.setSoundMode(true);
		}
		else{
			AudioScript.setSoundMode(false);
		}
 	}

 	void toggleMusic(UIToggleButton sender){
		if (sender.selected){
			AudioScript.setMusicMode(true);
		}
		else{
			AudioScript.setMusicMode(false);
		}
	}
}