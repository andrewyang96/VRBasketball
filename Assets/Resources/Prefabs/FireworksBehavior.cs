using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// fireworks last 0.5 seconds
		Destroy (gameObject, 0.55f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
