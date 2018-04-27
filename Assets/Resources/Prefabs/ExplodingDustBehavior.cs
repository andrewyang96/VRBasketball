using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingDustBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// dust explosion effect lasts 0.25 seconds
		Object.Destroy (gameObject, 0.3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
