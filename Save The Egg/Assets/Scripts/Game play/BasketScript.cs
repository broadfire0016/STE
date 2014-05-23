using UnityEngine;
using System.Collections;

public class BasketScript : MonoBehaviour {
	
	private int score = 0;
	public GameObject anim1, anim2, anim3;

	void Start(){
		anim1.gameObject.SetActive(false);
		anim2.gameObject.SetActive(false);
		anim3.gameObject.SetActive(false);
	}

	void OnTriggerEnter(Collider egg){
		if(egg.tag == "White Egg"){
			score += 2;
			anim1.gameObject.SetActive(true);
			Invoke("Start",1.2f);
			//animation.Play("plus");

		}else if(egg.tag == "Rotten Egg"){
			score -= 3;
			anim2.gameObject.SetActive(true);
			Invoke("Start",1.2f);
		}else if(egg.tag == "Gold Egg"){
			score += 4;
			anim3.gameObject.SetActive(true);
			Invoke("Start",1.2f);
		}
		if (score < 0)
			score = 0;

	}
	
		
	public int getScore(){
		return score;
	}
	
}
