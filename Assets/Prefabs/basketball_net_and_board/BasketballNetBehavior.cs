using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballNetBehavior : MonoBehaviour {
	MainBehavior mainScript;

	// Use this for initialization
	void Start () {
		mainScript = GameObject.Find ("Floor").GetComponent<MainBehavior> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		Rigidbody rb = other.gameObject.GetComponent<Rigidbody> ();
		if (rb.velocity.y < 0) {
			// if the ball is coming down
			mainScript.incrementScore ();
		}
	}
}
