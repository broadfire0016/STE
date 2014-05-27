using UnityEngine;
using System.Collections;

public class AudioScript : MonoBehaviour {

	private static AudioSource SoundSource;
	private static AudioSource MusicSource;
	public AudioClip Music;
	public AudioClip Sound;


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

	public static void setMusicMode(bool mode){
		MusicSource.mute = mode;
	}

	public static void setSoundMode(bool mode){
		SoundSource.mute = mode;
	}
}
