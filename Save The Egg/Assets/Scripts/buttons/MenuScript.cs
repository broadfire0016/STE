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
		post.positionFromBottomLeft (0f, 0.10f);
		post.userData = "post";

		//play game
		playButton = UIButton.create("PlayBtn_normal.png","PlayBtn_active.png",0,0);
		playButton.touchDownSound = Click;
		playButton.parentUIObject = post;
		playButton.positionFromTopLeft (0.190f, 0.108f);
		//playButton.pixelsFromRight( 0 );
		playButton.setSize(playButton.width/ scaleFactor , playButton.height / scaleFactor);
		playButton.onTouchUpInside += sender => Application.LoadLevel("Loading");
		//post.scale = new Vector3 (1.5f, 1.5f, 1.5f);

		//view collections of toy darts
		collectionButton = UIButton.create("CollectionBtn_normal.png","CollectionBtn_active.png",0,0);
		//collectionButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		collectionButton.positionFromTopLeft( 0.64f, 0.17f );
		collectionButton.parentUIObject = post;
		collectionButton.onTouchUpInside += sender => Application.LoadLevel("collections");
		collectionButton.touchDownSound = Click;
		collectionButton.setSize(collectionButton.width/scaleFactor, collectionButton.height/scaleFactor);
		
		//store
		storeButton = UIButton.create("StoreBtn_normal.png","StoreBtn_active.png",0,0);
		//storeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		storeButton.positionFromTopLeft( 0.695f, 0.17f );
		storeButton.parentUIObject = post;
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");
		storeButton.touchDownSound = Click;
		storeButton.setSize(storeButton.width/scaleFactor,storeButton.height/scaleFactor);
		
		//high score
		highScoreButton = UIButton.create("HighScoBtn_normal.png","HighScoBtn_active.png",0,0);
		//highScoreButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		highScoreButton.positionFromTopLeft( 0.75f, 0.17f );
		highScoreButton.parentUIObject = post;
		highScoreButton.onTouchUpInside += sender => Application.LoadLevel("HS");
		highScoreButton.touchDownSound = Click;
		highScoreButton.setSize(highScoreButton.width/scaleFactor,highScoreButton.height/scaleFactor);
		
		//credits
		creditsButton = UIButton.create("CreditsBtn_normal.png","CreditsBtn_activel.png",0,0);
		creditsButton.positionFromTopLeft( 0.805f, 0.17f );
		creditsButton.onTouchUpInside += sender => Application.LoadLevel("credits");
		creditsButton.parentUIObject = post;
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