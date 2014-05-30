using UnityEngine;
using System.Collections;

public class chicken : MonoBehaviour {

public float delay;
private Animator ChickenHead;

	// Use this for initialization
	void Start () {
	 	//animation["gameplay-chicken"].time = delay;
	 	ChickenHead = this.gameObject.GetComponent<Animator>();
	 	ChickenHead.ForceStateNormalizedTime(delay);
	}

	//1.0
}
