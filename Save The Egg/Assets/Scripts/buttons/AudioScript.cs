using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	private static AudioSource SoundSource;
	private static AudioSource MusicSource;
	private static AudioSource LevelMusicSource;
	private static bool status1;
	private static bool status2;
	public AudioClip LevelMusic;
	public AudioClip Music;
	public AudioClip Sound;
	
	void Start(){
		if(status2 == true){
			LevelMusicSource.mute = true;
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
		MusicSource = AddAudio (Music, false, true, 1f);
		LevelMusicSource = AddAudio (LevelMusic, false, true, 0.3f);
		SoundSource.mute = false;
		MusicSource.mute = false;
		LevelMusicSource.mute = getLevelMusicMode();
		//SoundSource.Play ();
		MusicSource.Play();

		if(Application.loadedLevelName != "AGAIN" && Application.loadedLevelName != "collections" && Application.loadedLevelName != "credits" 
		   && Application.loadedLevelName != "gameOver" && Application.loadedLevelName != "gameStore" && Application.loadedLevelName != "HS" 
		   && Application.loadedLevelName != "levelComplete" && Application.loadedLevelName != "Loading" && Application.loadedLevelName != "shorcuts"){
				LevelMusicSource.Play();
				MusicSource.Stop();
		}

	}
	
	 void Update(){
		if(Application.loadedLevelName == "AGAIN")
			status2 = status1;
	}

	public static void setMusicMode(bool mode){
		MusicSource.mute = mode;
		LevelMusicSource.mute = MusicSource.mute;
		status1 = mode;
	}

	public static void setSoundMode(bool mode){
		SoundSource.mute = mode;
	}

	public static bool getMusicMode(){
		return MusicSource.mute;
	}

	public static bool getSoundMode(){
		return SoundSource.mute;
	}

	public static bool getLevelMusicMode(){
		return LevelMusicSource.mute;
	}
}
