using UnityEngine;
using System.Collections;

public class chicken : MonoBehaviour {

public float delay;

	// Use this for initialization
	void Start () {
	 	animation["gameplay-chicken"].time = delay;
	}

}
