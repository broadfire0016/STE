using UnityEngine;
using System.Collections;

public class ToyDartMotionScript : MonoBehaviour 
{
	public	AudioClip dart;
	public AudioSource SoundBG;

	float time = 0;
	bool touch = false;
	Vector3 startPosition, currentPostion, endPosition;

	private RaycastHit hit;

	
	void IncreaseTime()
	{
		time += Time.deltaTime;
	}

	void OnTouchStay() 
	{
		touch = true;
		//print ("OnTouchStay " + touch);
		IncreaseTime ();
		startPosition = Input.mousePosition;
	}

	void OnTouchExit()
	{
		Vector3 direction;
		currentPostion = Input.mousePosition;
		endPosition = currentPostion - startPosition;
		if (time < 1 && endPosition.y > 15) 
		{
			touch = false;

			audio.clip = dart;
			audio.Play ();

			if(!touch)
			{
				//direction of dart (left & right)
				if(endPosition.x < -40)
					endPosition.x = -40;
				if (endPosition.x > 40)
					endPosition.x = 40;

				if (endPosition.y > 500)
				{
					endPosition.y = 500;
					direction = new Vector3((endPosition.y - 200),(endPosition.y),(endPosition.x * -1));
				}
				else
				{
					direction = new Vector3((endPosition.y + 30),(endPosition.y),(endPosition.x * -1));
				}
				//gameObject.transform.Rotate(endPosition.y * 0.10f, endPosition.y * 0.10f, endPosition.x * 0.10f);
				gameObject.rigidbody.isKinematic = false;
				//Quaternion rotate = Quaternion.LookRotation(direction);
				gameObject.transform.Rotate(endPosition.y,0,endPosition.x * -1);
				gameObject.rigidbody.AddForce(direction * 7f);
				//gameObject.rigidbody.AddForce(new Vector3(rotate.y, rotate.y, rotate.x) * 7f);
				//gameObject.rigidbody.velocity = direction/3f;
				//print (endPosition);
			}
			//print ("OnTouchUp " + touch);
		}
		time = 0;

	}


}
