﻿using UnityEngine;
using System.Collections;

public class settings : MonoBehaviour {

	private float hSliderValue1 = 0.0f;
	private float hSliderValue2 = 0.0f;
	public GUISkin settingSkin;
	public Texture2D btnOK;
	public Texture2D btnCancel;
	
	private AudioSource SoundSource;
	private AudioSource MusicSource;
	public AudioClip sound;
	public AudioClip music;
	
   
	AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float volume){
	    AudioSource newAudio = gameObject.AddComponent <AudioSource>();
		newAudio.clip = clip;
		newAudio.loop = loop;
		newAudio.playOnAwake = playAwake;
		newAudio.volume = volume;
		return newAudio;
	}

	void Awake(){
		SoundSource = AddAudio (sound, true, true, 0.5f);
		MusicSource = AddAudio (music, true, true, 0.5f);
		SoundSource.mute = true;
		MusicSource.mute = true;
		SoundSource.Play ();
		MusicSource.Play();
	}

	void OnGUI () {
		GUI.skin = settingSkin;

		GUI.BeginGroup(new Rect(Screen.width/2-265,Screen.height/2-210,1000,1000));
		GUI.Box(new Rect(0,0,530,415), "");
		
		GUI.Label(new Rect(250,130,150,30),"Sound");
		
		//GUI.Box(new Rect(250,130,150,30), iconS);


		hSliderValue1 = GUI.HorizontalSlider(new Rect(180,180,180,40),hSliderValue1,0.0f, 10.0f);
		SoundSource.volume = hSliderValue1/10.0f;
		
		
		if(GUI.Button(new Rect(370,160,50,50),"")){
			hSliderValue1 = 0.0f;
			SoundSource.mute = true;
		}
		else{
			SoundSource.mute = false;
		}
	
		GUI.Label(new Rect(250,220,150,30), "Music");
		//GUI.Box(new Rect(250,130,150,30), iconM);
		hSliderValue2 = GUI.HorizontalSlider(new Rect(180,265,180,40), hSliderValue2, 0.0f, 10.0f);
		MusicSource.volume = hSliderValue2/10.0f;
		
		if(GUI.Button(new Rect(370,240,50,50),"")){
			hSliderValue2 = 0.0f;
			MusicSource.mute = true;
		}
		else{
			MusicSource.mute = false;

		}

		//ok and cancel button
		
		if(GUI.Button(new Rect(140,355,120,40), btnOK)){//OK
			Application.LoadLevel("mainMenu");
		}
		else if(GUI.Button(new Rect(280,355,120,40), btnCancel)){//Cancel
			Application.LoadLevel("mainMenu");
		}
		GUI.EndGroup();
	}
}	
 