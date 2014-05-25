// Script attached to Main Menu UI, incharged of the buttons and state of sound and music in the game.
//Author: Aiza Aviso

using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	public AudioClip Click;
 	AudioClip Click2, Click3;
 	private AudioSource SoundSource;
 	private AudioSource MusicSource;
 	public AudioClip Music;
 	public AudioClip Sound;
 	private UIButton playBtn, collectBtn, storeBtn, hsBtn, creditsBtn ;


	// Use this for initialization
	void Start () {

		Click2 = Click;
		var scaleFactor = ScaleFactor.GetScaleFactor ();

		//main menu
		//post
		/*var post = UIButton.create("post.png","post.png",0,0);
		post.positionFromBottomLeft( -0.05f, 0.018f );
		//post.positionFromBottomRight(0.1f, 0.01f);
		post.setSize(post.width/ scaleFactor , post.height / scaleFactor);
		//post.userData = "post";
		//post.OnTouchUp += OnButtonUp;
		//post.OnTouchDown += OnButtonDown;
		//post.OnTouchInside += OnBottonSelect;
*/
		
		//play game
		var playButton = UIButton.create("PlayBtn_normal.png","PlayBtn_active.png",0,0);
		playBtn = playButton;
		playButton.positionFromBottomLeft( 0.40f, 0.05f );
		playButton.touchDownSound = Click;
		playButton.setSize(playButton.width/ scaleFactor , playButton.height / scaleFactor);
		playButton.onTouchUpInside += sender => Application.LoadLevel("Loading");
		
		//view collections of toy darts
		var collectionButton = UIButton.create("CollectionBtn_normal.png","CollectionBtn_active.png",0,0);
		collectBtn = collectionButton;
		collectionButton.positionFromBottomLeft( 0.35f, 0.08f );
		//collectionButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		collectionButton.onTouchUpInside += sender => Application.LoadLevel("collections");
		collectionButton.touchDownSound = Click;
		collectionButton.setSize(collectionButton.width/scaleFactor, collectionButton.height/scaleFactor);
		
		//store
		var storeButton = UIButton.create("StoreBtn_normal.png","StoreBtn_active.png",0,0);
		storeBtn = storeButton;
		storeButton.positionFromBottomLeft( 0.292f, 0.08f );
		//storeButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		storeButton.onTouchUpInside += sender => Application.LoadLevel("gameStore");
		storeButton.touchDownSound = Click;
		storeButton.setSize(storeButton.width/scaleFactor,storeButton.height/scaleFactor);
		
		//high score
		var highScoreButton = UIButton.create("HighScoBtn_normal.png","HighScoBtn_active.png",0,0);
		hsBtn = highScoreButton;
		highScoreButton.positionFromBottomLeft( 0.234f, 0.08f );
		//highScoreButton.highlightedTouchOffsets = new UIEdgeOffsets(30);
		highScoreButton.onTouchUpInside += sender => Application.LoadLevel("HS");
		highScoreButton.touchDownSound = Click;
		highScoreButton.setSize(highScoreButton.width/scaleFactor,highScoreButton.height/scaleFactor);
		
		//credits
		var creditButton = UIButton.create("CreditsBtn_normal.png","CreditsBtn_activel.png",0,0);
		creditsBtn = creditButton;
		creditButton.positionFromBottomLeft( 0.178f, 0.08f );
		creditButton.onTouchUpInside += sender => Application.LoadLevel("credits");
		creditButton.touchDownSound = Click;
		creditButton.setSize(creditButton.width/scaleFactor,creditButton.height/scaleFactor);

		//sound
		var sound = UIToggleButton.create( "sound_normal.png","sound_mute.png","sound_active.png",0,0 );
		sound.positionFromBottomLeft( 0.002f, 0.024f );
		sound.onToggle += (sender,selected) => toggleSound(sender);
		sound.selected = false;
		sound.setSize(sound.width/scaleFactor, sound.height/scaleFactor);
		//creditButton.touchDownSound = Click;
		
		//music
		var music = UIToggleButton.create( "music_normal.png","music_mute.png","music_active.png",0,0 );
		music.positionFromBottomLeft( 0.002f, 0.25f );
		//sound.onToggle += sender => Debug.Log("Sound err");
		music.onToggle += (sender,selected) => toggleMusic(sender);
		music.selected = false;
		music.setSize(music.width/ scaleFactor,music.height / scaleFactor);
		//creditButton.touchDownSound = Click;

	}	

	void Update(){

		  if (SoundSource.mute == true){
		   playBtn.touchDownSound = Click3;
		   collectBtn.touchDownSound = Click3;
		   storeBtn.touchDownSound = Click3;
		   hsBtn.touchDownSound = Click3;
		   creditsBtn.touchDownSound = Click3;
		  }
		  else{
		   playBtn.touchDownSound = Click;
		   collectBtn.touchDownSound = Click;
		   storeBtn.touchDownSound = Click;
		   hsBtn.touchDownSound = Click;
		   creditsBtn.touchDownSound = Click;
		  }
 	}

 	void toggleSound(UIToggleButton sender){
		if (sender.selected){
		    SoundSource.mute = true;
		}
		else{
		   SoundSource.mute = false;
		}
 	}

 	void toggleMusic(UIToggleButton sender){

		if (sender.selected){
			MusicSource.mute = true;
		}
		else{
			MusicSource.mute = false;
		}
	}
 

	AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float volume){

		  AudioSource newAudio = gameObject.AddComponent <AudioSource>();
		  newAudio.clip = clip;
		  newAudio.loop = loop;
		  newAudio.playOnAwake = playAwake;
		  newAudio.volume = volume;
		  return newAudio;
  }

	void Awake(){

		  SoundSource = AddAudio (Sound, false, true, 1f);
		  MusicSource = AddAudio (Music, true, true, 1f);
		  SoundSource.mute = false;
		  MusicSource.mute = false;
		  //SoundSource.Play ();
		  MusicSource.Play();
	 }
	
}