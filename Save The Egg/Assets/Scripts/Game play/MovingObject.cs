using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

	public float _objspeed = 10.0f;
	public float _distance1 = 100.0f;
	public float _distance2 = 200.0f;
	public Transform basket;
	float _travel = 0f;

	// Use this for initialization
	void Start () {
	
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
}
