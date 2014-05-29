using UnityEngine;
using System.Collections;

public class BallMotionScript : MonoBehaviour {
	public	AudioClip dart;
	public AudioSource SoundBG;

	float time = 0;
	bool touch = true;
	bool rayHit;
	Vector3 startPosition, currentPostion, endPosition;
	Vector3 direction;	

	void IncreaseTime(){
		time += Time.deltaTime*2f;
	}

/*	void OnTouchStay() 
	{
		touch = true;
		//print ("OnTouchStay " + touch);
		IncreaseTime ();
		startPosition = Input.mousePosition;

	}

	void OnTouchExit()
	{
		currentPostion = Input.mousePosition;
		endPosition = currentPostion - startPosition;
		if (time < 1f && endPosition.y > 15) 
		{
			touch = false;

			audio.clip = dart;
			audio.Play ();

			if(touch == false)
			{
				print (time);
				//direction of dart (left & right)
				if(endPosition.x < -40)
					endPosition.x = -40;
				if (endPosition.x > 40)
					endPosition.x = 40;

				if (endPosition.y > 300)
				{
					endPosition.y = 300;
					direction = new Vector3((endPosition.y - 200),(endPosition.y),(endPosition.x * -1));
				}
				else
				{
					direction = new Vector3((endPosition.y + 30),(endPosition.y),(endPosition.x * -1));
				}
				gameObject.rigidbody.isKinematic = false;
				gameObject.rigidbody.velocity = direction / (time * 100f);
			}
		}
		time = 0;

	}*/

	void Update(){
		gameObject.transform.Rotate(new Vector3(0,100f,0) * Time.deltaTime);
		Swipe ();

	}

	void Swipe(){
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

#if UNITY_EDITOR

		if(Physics.Raycast(ray,out hit)){
			if(hit.collider.tag == "Ball"){
				rayHit = true;
				if(Input.GetMouseButtonDown(0)){
					touch = true;
					IncreaseTime ();
					//print ("OnTouchStay " + touch);
					startPosition = Input.mousePosition;
				}
			}
		}
		if(Input.GetMouseButtonUp(0)){

			currentPostion = Input.mousePosition;
			endPosition = currentPostion - startPosition;
			print (currentPostion);
			if (time > 0.01f && rayHit == true && endPosition.y > 100f) 
			{
				touch = false;
				audio.clip = dart;
				audio.Play ();
				
				if(touch == false)
				{
					print (time);
					//direction of dart (left & right)
					if(endPosition.x < -60)
						endPosition.x = -60;
					if (endPosition.x > 60)
						endPosition.x = 60;
					
					if (endPosition.y > 300){
						endPosition.y = 300;
						direction = new Vector3((endPosition.y),(endPosition.y - 50f),(endPosition.x * -1));
					}
					else
						direction = new Vector3((endPosition.y + 30),(endPosition.y),(endPosition.x * -1));

					gameObject.rigidbody.isKinematic = false;
					gameObject.rigidbody.velocity = direction / (time * 300f);
				}
			}
			time = 0;
			rayHit = false;
		}
#endif

#if UNITY_IOS

	if(Input.touches.Length > 0){
	
		Touch t = Input.GetTouch(0);
		
		if(Physics.Raycast(ray,out hit)){
			if(hit.collider.tag == "Ball"){
				rayHit = true;
				if(t.phase == TouchPhase.Began){
					touch = true;
					IncreaseTime ();
					startPosition = t.position;
				}
			}
		}

		if(t.phase == TouchPhase.Ended){
			currentPostion = t.position;
			endPosition = currentPostion - startPosition;
				if (time > 0.01f && rayHit == true && endPosition.y > 100f){
				touch = false;
				audio.clip = dart;
				audio.Play ();
				
				if(touch == false)
				{
					print (time);
					//direction of dart (left & right)
					if(endPosition.x < -60)
						endPosition.x = -60;
					if (endPosition.x > 60)
						endPosition.x = 60;
					
					if (endPosition.y > 300){
						endPosition.y = 300;
						direction = new Vector3((endPosition.y),(endPosition.y - 50f),(endPosition.x * -1));
					}
					else
						direction = new Vector3((endPosition.y + 30),(endPosition.y),(endPosition.x * -1));
					
					gameObject.rigidbody.isKinematic = false;
					gameObject.rigidbody.velocity = direction / (time * 300f);
				}
			}
			time = 0;
			rayHit = false;
		}
	}
#endif
	
	}	
}
