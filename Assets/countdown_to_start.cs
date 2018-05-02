using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdown_to_start : MonoBehaviour {

	public Text C;
	public float readycounter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		readycounter = GameObject.Find ("Floor").GetComponent<MainBehavior> ().countDown;
		readycounter = Mathf.CeilToInt (readycounter);
		C.text = readycounter.ToString();
	}
}
