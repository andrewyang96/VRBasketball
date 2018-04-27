using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBehavior : MonoBehaviour
{

    public enum GameState
    {
        MAIN_MENU,
        GAME_START,
        GAME_COUNTDOWN_TO_START,
        GAME_PLAY,
        GAME_OVER
    }

    public GameState s;
    public float countUp = 10.0f;
	public int score;
	private GameObject basketballPrefab;
	private GameObject mostRecentBasketball;
	public GameObject mainMenu;
	public GameObject timeDisplay;
	public GameObject scoreDisplay;

	public bool isInTimedGame = true;

    // Use this for initialization
    void Start()
    {
        s = GameState.MAIN_MENU;
        Debug.Log("start");
		score = 0;
		basketballPrefab = (GameObject)Resources.Load ("Prefabs/nba_basketball", typeof (GameObject));
		respawnBasketball ();
    }

    // Update is called once per frame
    void Update()
    {
		TimeTrialGameStateMachine();

		if (s == GameState.MAIN_MENU) {
			mainMenu.SetActive (true);
			timeDisplay.SetActive (false);
			scoreDisplay.SetActive (false);
		} 
		else {
			mainMenu.SetActive (false);
			timeDisplay.SetActive (true);
			scoreDisplay.SetActive (true);
			
		}

    }
		
	public void TimeTrialGameStateMachine(){
		if (OVRInput.Get(OVRInput.Button.Start) && (s == GameState.MAIN_MENU))
		{ //start button pressed
			Debug.Log("mode chosen");
			s = GameState.GAME_COUNTDOWN_TO_START;
		}
		else if (s == GameState.GAME_COUNTDOWN_TO_START)
		{
			Debug.Log(countUp);
			Debug.Log ("countdown to start");
			//animation
			countUp -= Time.deltaTime;
			if (countUp <= 0.0f)
			{
				s = GameState.GAME_PLAY;
				countUp = 10.0f;
			}
		}
		else if (s == GameState.GAME_PLAY)
		{
			Debug.Log("game play");
			Debug.Log(countUp);
			countUp -= Time.deltaTime;
			if (countUp <= 0.0f)
			{
				s = GameState.GAME_OVER;
				countUp = 3.0f;
			}
		}
		else if (s == GameState.GAME_OVER)
		{
			Debug.Log("game over");
			Debug.Log(countUp);
			countUp -= Time.deltaTime;
			if (countUp >= 0.0f)
			{
				s = GameState.MAIN_MENU;
				countUp = 3.0f;
			}
		}
	}

	public void incrementScore() {
		print ("Score!");
		score += 1;
	}

	private void respawnBasketball() {
		mostRecentBasketball = Instantiate (basketballPrefab, new Vector3 (0, 0.25f, 0.25f), Quaternion.identity);
	}

	public void respawnBasketball(GameObject basketballThrown) {
		if (basketballThrown != mostRecentBasketball)
			return;
		respawnBasketball ();
	}
}