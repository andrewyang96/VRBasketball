using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour {

	public Text C;
	public int score;

	// Use this for initialization
	void Start () {
		//timeLeft = GameObject.Find("Floor").GetComponent<MainBehavior>().countUp;
	}

	// Update is called once per frame
	void Update () {
		score = GameObject.Find("Floor").GetComponent<MainBehavior>().score;
		C.text = "Score:\n" + score.ToString();
	}
}
