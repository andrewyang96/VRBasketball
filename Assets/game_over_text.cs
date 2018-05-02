using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_over_text : MonoBehaviour {


	public Text C;
	public float timeLeft;
	private int score;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		score = GameObject.Find("Floor").GetComponent<MainBehavior>().score;
		C.text = "game over\n" + "your score was " + score.ToString();
	}
}
