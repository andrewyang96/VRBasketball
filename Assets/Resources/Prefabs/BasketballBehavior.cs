using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballBehavior : MonoBehaviour {
	float destroyCountdown;
	const float MAX_DESTROY_TIME = 2f;
	const float MAGNITUDE_THRESHOLD = 1f;
	bool wasThrown;

	// Use this for initialization
	void Start () {
		destroyCountdown = MAX_DESTROY_TIME;
		wasThrown = false;
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		if (wasThrown && rb.velocity.magnitude < MAGNITUDE_THRESHOLD) {
			if (destroyCountdown <= 0) {
				Destroy (gameObject);
			}
			destroyCountdown -= Time.deltaTime;
			print (destroyCountdown);
		} else {
			destroyCountdown = MAX_DESTROY_TIME;
		}
	}

	public void setWasThrown(bool thrown) {
		wasThrown = thrown;
	}
}
