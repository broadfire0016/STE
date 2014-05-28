using UnityEngine;
using System.Collections;

public class BallMotionScript : MonoBehaviour 
{
	public	AudioClip dart;
	public AudioSource SoundBG;

	float time = 0;
	bool touch = true;
	Vector3 startPosition, currentPostion, endPosition;
	Vector3 direction;

	private RaycastHit hit;

	
	void IncreaseTime()
	{
		time += Time.deltaTime*10f;
	}

	void OnTouchDown() 
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
		if (time > 0.1f || time < 0.2f && endPosition.y > 15) 
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

	}

	void Update(){
			gameObject.transform.Rotate(new Vector3(0,100f,0) * Time.deltaTime);
	}


}
