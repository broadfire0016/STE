//Audio Script Code. Determines the sound mode of the game if, its mute or unmute.
//author : Levi Joy Lim

using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	private AudioSource SoundSource, MusicSource, LevelMusicSource, LevelSoundSource;
	private static AudioSource soundsource, musicsource, levelmusicsource, levelsoundsource;
	public AudioClip LevelMusic, LevelSound;
	public AudioClip Music, Sound;
	private AudioClip sound;
	private static AudioScript instance;
	public static bool status;

	
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

		if (AudioScript.instance == null){
			AudioScript.instance = this;
			GameObject.DontDestroyOnLoad(this.gameObject);
		}
		else{
			Destroy(this.gameObject);
		}

		SoundSource = AddAudio (Sound, false, true, 1f);
		MusicSource = AddAudio (Music, true, true, 1f);
		LevelMusicSource = AddAudio (LevelMusic, true, true, 0.3f);
		LevelSoundSource = AddAudio (LevelSound, false, true, 0.3f);
		SoundSource.mute = false;
		MusicSource.mute = false;
		LevelMusicSource.mute = false;
		LevelSoundSource.mute = false;
		sound = Sound;
		soundsource = SoundSource;
		musicsource = MusicSource;
		levelmusicsource = LevelMusicSource;
		levelsoundsource = LevelSoundSource;
		//SoundSource.Play ();
		//MusicSource.Play();

	}

	public AudioClip getSoundClip(){
		//print (SoundSource.mute);
		if (SoundSource.mute == false)
			return sound;
		else
			return null;
	}

	public void setMusicMode(bool mode){
		MusicSource.mute = mode;
		LevelMusicSource.mute = MusicSource.mute;
	}

	public void PlayGameMusic(){
		status = false;
		MusicSource.Stop ();
		LevelMusicSource.Play ();
	}

	public void PlayMenuMusic(){
		LevelMusicSource.Stop ();
		MusicSource.Play ();
		status = true;
	}

	public void StopMusic(){
		LevelMusicSource.Stop ();
		MusicSource.Stop ();
		status = true;
	}

	public void setSoundMode(bool mode){
		SoundSource.mute = mode;
		LevelSoundSource.mute = mode;
	}

	public bool getMusicMode(){
		return musicsource.mute;
	}

	public bool getSoundMode(){
		return soundsource.mute;
	}

	public bool getLevelMusicMode(){
		return levelmusicsource.mute;
	}

	public bool getLevelSoundMode(){
		return levelsoundsource.mute;
	}
}
