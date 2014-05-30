//Audio Script Code. Determines the sound mode of the game if, its mute or unmute.
//author : Levi Joy Lim

using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	private static AudioSource SoundSource;
	private static AudioSource MusicSource;
	private static AudioSource LevelMusicSource;
	private static AudioSource LevelSoundSource;
	private static bool status1, status2, status3, status4;
	public AudioClip LevelMusic, LevelSound;
	public AudioClip Music;
	public AudioClip Sound;
	
	// check the sound mode every scene
	
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
		LevelMusicSource = AddAudio (LevelMusic, true, true, 0.3f);
		LevelSoundSource = AddAudio (LevelSound, false, true, 0.3f);
		SoundSource.mute = false;
		MusicSource.mute = false;
		LevelMusicSource.mute = getLevelMusicMode();
		LevelSoundSource.mute = getLevelSoundMode();
		//SoundSource.Play ();
		MusicSource.Play();

		if(Application.loadedLevelName != "AGAIN" && Application.loadedLevelName != "collections" && Application.loadedLevelName != "credits" 
		   && Application.loadedLevelName != "gameOver" && Application.loadedLevelName != "gameStore" && Application.loadedLevelName != "HS" 
		   && Application.loadedLevelName != "levelComplete" && Application.loadedLevelName != "Loading" && Application.loadedLevelName != "shortcuts"){
				LevelMusicSource.Play();
				MusicSource.Stop();
		}

	}


	public static void setMusicMode(bool mode){
		MusicSource.mute = mode;
		LevelMusicSource.mute = MusicSource.mute;
	}

	public static void setSoundMode(bool mode){
		SoundSource.mute = mode;
		LevelSoundSource.mute = mode;
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

	public static bool getLevelSoundMode(){
		return LevelSoundSource.mute;
	}
}
