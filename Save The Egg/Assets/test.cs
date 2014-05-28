using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector3 worldPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height/2, gameObject.transform.position.x));
		gameObject.transform.position = new Vector3(worldPoint.z, worldPoint.y, worldPoint.x);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
