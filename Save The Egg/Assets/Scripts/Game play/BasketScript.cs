using UnityEngine;
using System.Collections;

public class BasketScript : MonoBehaviour {
	
	private int score = 0;
	public GameObject plus2, minus3, plus4, freeze;
	MovingObject blue;
	float time, seconds;

	void Start(){
		plus2.gameObject.SetActive(false);
		minus3.gameObject.SetActive(false);
		plus4.gameObject.SetActive(false);
		freeze.gameObject.SetActive(false);
	}

	void OnTriggerEnter(Collider egg){
		if(egg.tag == "White Egg"){
			score += 2;
			plus2.gameObject.SetActive(true);
			Invoke("Start",1.2f);
			//animation.Play("plus");
		}else if(egg.tag == "Rotten Egg"){
			score -= 3;
			minus3.gameObject.SetActive(true);
			Invoke("Start",1.2f);
		}else if(egg.tag == "Gold Egg"){
			score += 4;
			plus4.gameObject.SetActive(true);
			Invoke("Start",1.2f);
		}else if(egg.tag == "Blue Egg"){
			blue = gameObject.GetComponent<MovingObject>();
			blue.MoveSlow();
			freeze.SetActive(true);
			Invoke("reset", 5f);
		}else if(egg.tag == "Red Egg"){
			Timer.plusTenSeconds();
			Invoke("reset", 5f);
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
