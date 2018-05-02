using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown : MonoBehaviour {


	public Text C;
	public float timeLeft;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft = GameObject.Find("Floor").GetComponent<MainBehavior>().countDown;
		timeLeft = Mathf.CeilToInt (timeLeft);
		C.text = "TIME:\n" + timeLeft.ToString();
	}
}
