using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

	public static float _objspeed = 0.1f;
	public float _distance1 = 100.0f;
	public float _distance2 = 200.0f;
	public Transform basket;
	public static float _travel = 0f;
	static float  slowSpeed = 0.01f , slowTravel = 0.001f;

	// Use this for initialization
	void Start () {
		//InvokeRepeating("MoveRight" , 0.1f, 0.02f);
	}
	
	// Update is called once per frame
	void Update () {
		if (_travel < _distance1)
			MoveLeft();
		if (_travel >= _distance1 && _travel < _distance2)
			MoveRight();
		if (_travel >= _distance2)
			_travel = 0;
	}


	void MoveLeft(){
		transform.Translate(new Vector3(_objspeed, 0, 0));
			_travel += 1f;
	}

	void MoveRight(){
		transform.Translate(new Vector3(-_objspeed, 0, 0));
			_travel += 1f;
	}

	public static void MoveSlow(){
		_objspeed = slowSpeed;
		_travel += 0.001f;
	}

	public static void MoveNormal(){
		_objspeed = 0.1f;
		_travel += 1f;
	}
}
