using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballNetBehavior : MonoBehaviour {
	MainBehavior mainScript;
	GameObject fireworksPrefab;
	BoxCollider bc;

	// Use this for initialization
	void Start () {
		mainScript = GameObject.Find ("Floor").GetComponent<MainBehavior> ();
		fireworksPrefab = (GameObject)Resources.Load ("Prefabs/fireworks", typeof (GameObject));
		bc = GetComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		Rigidbody rb = other.gameObject.GetComponent<Rigidbody> ();
		if (rb.velocity.y < 0) {
			// if the ball is coming down
			mainScript.incrementScore ();

			// fireworks animation
			Instantiate(fireworksPrefab, bc.transform.position, Quaternion.identity);
		}
	}
}
