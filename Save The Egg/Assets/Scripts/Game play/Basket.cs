//This Script in charge of the scoring when the basket catches the egg.
//author: Levi

using UnityEngine;
using System.Collections;

public class Basket : MonoBehaviour {
	
	public AudioClip blueE, redE, whiteE, rottenE, goldE;
	private static int score = 0;
	public GameObject plus2, minus3, plus4, freeze, plus10sec;
	float time, seconds;
	float _objspeed = 0.1f;
	float _distance1 = 100.0f;
	float _distance2 = 200.0f;
	float _travel = 0f, _travelRate = 0f;
	float  slowSpeed = 0.05f , slowTravel = 0.5f;
	float normalSpeed = 0.1f, normalTravel = 1f;
	
	void Start(){
		plus2.gameObject.SetActive(false);
		minus3.gameObject.SetActive(false);
		plus4.gameObject.SetActive(false);
		freeze.gameObject.SetActive(false);
		plus10sec.gameObject.SetActive(false);

		_objspeed = normalSpeed;
		_travelRate = normalTravel;

	}

	void Update(){
		if(Input.GetButtonUp("Fire2"))
			score++;

		if (_travel < _distance1)
			MoveLeft();
		if (_travel >= _distance1 && _travel < _distance2)
			MoveRight();
		if (_travel >= _distance2)
			_travel = 0;
	}

	void OnTriggerEnter(Collider egg){

		if(egg.tag == "White Egg"){
			score += 2;
			plus2.gameObject.SetActive(true);
			Invoke("Start",1.2f);
			audio.clip = whiteE;
			audio.Play();
			//animation.Play("plus");
		}else if(egg.tag == "Rotten Egg"){
			score -= 3;
			minus3.gameObject.SetActive(true);
			Invoke("Start",1.2f);
			audio.clip = rottenE;
			audio.Play();
		}else if(egg.tag == "Gold Egg"){
			score += 4;
			plus4.gameObject.SetActive(true);
			Invoke("Start",1.2f);
			audio.clip = goldE;
			audio.Play();
		}else if(egg.tag == "Blue Egg"){
			MoveSlow();
			freeze.SetActive(true);
			Invoke("Start",1.2f);
			Invoke("reset", 5f);
			audio.clip = blueE;
			audio.Play();
		}else if(egg.tag == "Red Egg"){
			Timer.plusTenSeconds();
			Invoke("reset", 5f);
			plus10sec.SetActive(true);
			audio.clip = redE;
			audio.Play();
		}

		if (score < 0)
			score = 0;

	}
	
	void MoveLeft(){
		transform.Translate(new Vector3(_objspeed, 0, 0));
		_travel += _travelRate;
	}
	
	void MoveRight(){
		transform.Translate(new Vector3(-_objspeed, 0, 0));
		_travel += _travelRate;
	}
	
	public void MoveSlow(){
		_objspeed = slowSpeed;
		_travelRate = slowTravel;
	}
	
	public void MoveNormal(){
		_objspeed = normalSpeed;
		_travelRate = normalTravel;
	}

	public void resetScore(){
		score = 0;
	}
	
	public int getScore(){
		return score;
	}
	
	public void reset(){
		MoveNormal();
	}

}
