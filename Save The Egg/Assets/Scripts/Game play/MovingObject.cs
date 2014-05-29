using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

	public static float _objspeed = 0.1f;
	public float _distance1 = 100.0f;
	public float _distance2 = 200.0f;
	public Transform basket;
	float _travel = 0f, _travelRate = 0f;
	float  slowSpeed = 0.05f , slowTravel = 0.5f;
	float normalSpeed = 0.1f, normalTravel = 1f;

	// Use this for initialization
	void Start () {
		_objspeed = normalSpeed;
		_travelRate = normalTravel;
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
}
