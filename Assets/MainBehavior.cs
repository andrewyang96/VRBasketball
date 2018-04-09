using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBehavior : MonoBehaviour
{

    public enum GameState
    {
        MAIN_MENU,
        GAME_START,
        GAME_READY,
        GAME_COUNTDOWN,
        GAME_OVER
    }

    public GameState s;
    public float countUp = 0.0f;
    public float endTime = 3.0f;
	private int score;
	private GameObject basketballPrefab;
	private GameObject mostRecentBasketball;

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
        
        if (OVRInput.Get(OVRInput.Button.Start) && (s == GameState.MAIN_MENU))
        { //start button pressed
            Debug.Log("mode chosen");
            s = GameState.GAME_READY;
        }

        //Debug.log(countdown);
        if (s == GameState.GAME_READY)
        {
            Debug.Log(countUp);
            //animation
            countUp += Time.deltaTime;
            if (countUp >= 3.0f)
            {
                s = GameState.GAME_COUNTDOWN;
                countUp = 0.0f;
            }
        }
        else if (s == GameState.GAME_COUNTDOWN)
        {
            Debug.Log("game play");
            Debug.Log(countUp);
            countUp += Time.deltaTime;
            if (countUp >= endTime)
            {
                s = GameState.GAME_OVER;
                countUp = 0.0f;
            }
        }
        else if (s == GameState.GAME_OVER)
        {
            Debug.Log("game over");
            Debug.Log(countUp);
            countUp += Time.deltaTime;
            if (countUp >= 3.0f)
            {
                s = GameState.MAIN_MENU;
                countUp = 0.0f;
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