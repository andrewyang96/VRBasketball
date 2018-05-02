using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_over_text : MonoBehaviour {


	public Text C;
	public float timeLeft;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		C.text = "Game Over!";
	}
}
