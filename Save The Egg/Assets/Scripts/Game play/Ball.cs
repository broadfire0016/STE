﻿//Ball Motion Script. This Script mades the ball toss according to the direction of swipe.
//author Levi Joy Lim

using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	float time = 0;
	bool touch = true;
	bool rayHit;
	Vector3 startPosition, currentPostion, endPosition;
	Vector3 direction;	

	void IncreaseTime(){
		time += Time.deltaTime*2f;
	}
	
	void Update(){
		gameObject.transform.Rotate(new Vector3(0,100f,0) * Time.deltaTime);
		Swipe ();

	}

	void Swipe(){
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

#if UNITY_EDITOR
		Input.multiTouchEnabled = false;
		if(Physics.Raycast(ray,out hit)){
			if(hit.collider.tag == "Ball"){
				rayHit = true;
				if(Input.GetMouseButtonDown(0)){
					touch = true;
					IncreaseTime ();
					startPosition = Input.mousePosition;
				}
			}
		}
		if(Input.GetMouseButtonUp(0)){
			currentPostion = Input.mousePosition;
			endPosition = currentPostion - startPosition;
	
			if (time > 0.01f && rayHit == true && endPosition.y > 50f) 
			{
				touch = false;
		
				if(touch == false)
				{
					//direction of dart (left & right)
					if(endPosition.x < -60)
						endPosition.x = -60;
					if (endPosition.x > 60)
						endPosition.x = 60;
					
					if (endPosition.y > 300){
						endPosition.y = 300;
						direction = new Vector3((endPosition.y - 50),(endPosition.y - 50f),(endPosition.x * -1));
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
	//IOS Control
	if(Input.touches.Length > 0){
		Input.multiTouchEnabled = false;
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
				if (time > 0.01f && rayHit == true && endPosition.y > 50f){
				touch = false;
				
				if(touch == false)
				{
					
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
					gameObject.rigidbody.velocity = direction / (time * 250f);
				}
			}
			time = 0;
			rayHit = false;
		}
	}
#endif
	
	}
	void OnCollisionEnter (Collision other) {
		Invoke ("Destroy", 0.1f);
	}
	
	public void Destroy(){
		gameObject.SetActive (false);
	}
	
	void OnDisable(){
		CancelInvoke ();
	}
}
