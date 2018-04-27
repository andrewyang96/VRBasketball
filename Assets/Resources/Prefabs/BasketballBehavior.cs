using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballBehavior : MonoBehaviour {
	GameObject explodingDust;
	float destroyCountdown;
	const float MAX_DESTROY_TIME = 2f;
	const float MAGNITUDE_THRESHOLD = 1f;
	const float Y_COORD_LIMIT = -10f;
	bool wasThrown;

	// Use this for initialization
	void Start () {
		destroyCountdown = MAX_DESTROY_TIME;
		wasThrown = false;
		explodingDust = (GameObject)Resources.Load ("Prefabs/exploding_dust", typeof (GameObject));
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody rb = GetComponent<Rigidbody> ();
		if (wasThrown && rb.velocity.magnitude < MAGNITUDE_THRESHOLD) {
			if (destroyCountdown <= 0) {
				// destroy self once enough time has elapsed & initiate exploding dust effect
				destroySelfAnimation ();
			}
			destroyCountdown -= Time.deltaTime;
		} else {
			destroyCountdown = MAX_DESTROY_TIME;
		}

		// otherwise destroy self if y-coordinate is too low
		if (transform.position.y < Y_COORD_LIMIT) {
			destroySelfAnimation ();
		}
	}

	void destroySelfAnimation() {
		Destroy (gameObject);
		Instantiate (explodingDust, transform.position, transform.rotation);
	}

	public void setWasThrown(bool thrown) {
		wasThrown = thrown;
	}
}
