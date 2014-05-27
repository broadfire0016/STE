using UnityEngine;
using System.Collections;

public class BasketScript : MonoBehaviour {
	
	public AudioSource blueEgg;
	public AudioSource redEgg;
	public AudioSource whiteEgg;
	public AudioSource rottenEgg;
	public AudioSource goldEgg;

	public AudioClip blueE;
	public AudioClip redE;
	public AudioClip whiteE;
	public AudioClip rottenE;
	public AudioClip goldE;


	private int score = 0;
	public GameObject plus2, minus3, plus4, freeze, plus10sec;
	MovingObject blue;
	float time, seconds;

	void Start(){
		plus2.gameObject.SetActive(false);
		minus3.gameObject.SetActive(false);
		plus4.gameObject.SetActive(false);
		freeze.gameObject.SetActive(false);
		plus10sec.gameObject.SetActive(false);
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
			blue = gameObject.GetComponent<MovingObject>();
			blue.MoveSlow();
			freeze.SetActive(true);
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
	
		
	public int getScore(){
		return score;
	}
								
	public void reset(){
		blue.MoveNormal();
	}
		
}
