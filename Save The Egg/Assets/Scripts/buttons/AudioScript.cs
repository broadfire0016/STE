//Audio Script Code. Determines the sound mode of the game if, its mute or unmute.
//author : Levi Joy Lim

using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	private AudioSource SoundSource, MusicSource, LevelMusicSource, LevelSoundSource, GameOverSource, LevelCompleteSource;
	private AudioSource Plus2AudioSource, Minus3AudioSource, Plus4AudioSource, FreezeAudioSource, Plus10SecAudioSource, EggBreakSource;
	public AudioClip Plus2, Minus3, Plus4, Freeze, Plus10Sec, EggBreak;
	public AudioClip LevelMusic, LevelSound, GameOver, LevelComplete;
	public AudioClip Music, Sound;
	private AudioClip sound, levelsound;
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
		Plus2AudioSource = AddAudio (Plus2, false, true, 1f);
		Minus3AudioSource = AddAudio (Minus3, false, true, 1f);
		Plus4AudioSource = AddAudio (Plus4, false, true, 1f);
		FreezeAudioSource = AddAudio (Freeze, false, true, 1f);
		Plus10SecAudioSource = AddAudio (Plus10Sec, false, true, 1f);
		LevelMusicSource = AddAudio (LevelMusic, true, true, 0.3f);
		LevelSoundSource = AddAudio (LevelSound, false, true, 1f);
		GameOverSource = AddAudio (GameOver, false, true, 0.3f);
		LevelCompleteSource = AddAudio (LevelComplete, false, true, 0.3f);
		EggBreakSource = AddAudio (EggBreak, false, true, 1f);
		SoundSource.mute = false;
		MusicSource.mute = false;
		Plus2AudioSource.mute = false;
		Plus4AudioSource.mute = false;
		Minus3AudioSource.mute = false;
		FreezeAudioSource.mute = false;
		Plus10SecAudioSource.mute = false;
		LevelMusicSource.mute = false;
		LevelSoundSource.mute = false;
		EggBreakSource.mute = false;
		sound = Sound;
		levelsound = LevelSound;
	}

	public void setMusicMode(bool mode){
		MusicSource.mute = mode;
		LevelMusicSource.mute = MusicSource.mute;
		GameOverSource.mute = mode;
		LevelCompleteSource.mute = mode;
		
	}
	
	public void setSoundMode(bool mode){
		SoundSource.mute = mode;
		LevelSoundSource.mute = mode;
		Plus2AudioSource.mute = mode;
		Plus4AudioSource.mute = mode;
		Minus3AudioSource.mute = mode;
		FreezeAudioSource.mute = mode;
		Plus10SecAudioSource.mute = mode;
		EggBreakSource.mute = mode;
	}

	public AudioClip getSoundClip(){
		if (SoundSource.mute == false)
			return sound;
		else
			return null;
	}

	public AudioClip getLevelSoundClip(){
		if (LevelSoundSource.mute == false)
			return levelsound;
		else
			return null;
	}
	
	public void PlayPlus2(){
		Plus2AudioSource.Play ();
	}

	public void PlayMinus3(){
		Minus3AudioSource.Play ();
	}

	public void PlayPlus4(){
		Plus4AudioSource.Play ();
	}

	public void PlayPlus10sec(){
		Plus10SecAudioSource.Play ();
	}

	public void PlayFreeze(){
		Plus10SecAudioSource.Play ();
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

	public void PlayGameSound(){
		LevelSoundSource.Play();
	}

	public void PlayGameOver(){
		GameOverSource.Play ();
	}

	public void PlayLevelComplete(){
		LevelCompleteSource.Play ();
	}

	public void PlayBreakEgg(){
		EggBreakSource.Play ();
	}
	
	public void StopMusic(){
		LevelMusicSource.Stop ();
		MusicSource.Stop ();
		status = true;
	}
	
}
