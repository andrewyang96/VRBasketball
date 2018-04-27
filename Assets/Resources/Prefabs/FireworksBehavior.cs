using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworksBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// fireworks last 1.5 seconds
		Destroy (gameObject, 1.55f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
