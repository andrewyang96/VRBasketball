using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBehavior : MonoBehaviour
{

    public enum GameState
    {
        MAINMENU,
        GAMESTART,
        GAMEREADY,
        GAMECOUNTDOWN,
        GAMEOVER
    }

    public GameState s;
    public float countUp = 0.0f;
    public float endTime = 3.0f;
    // Use this for initialization
    void Start()
    {
        s = GameState.MAINMENU;
        Debug.Log("start");

    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.Get(OVRInput.Button.Start) && (s == GameState.MAINMENU))
        { //start button pressed
            Debug.Log("mode chosen");
            s = GameState.GAMEREADY;
        }

        //Debug.log(countdown);
        if (s == GameState.GAMEREADY)
        {
            Debug.Log(countUp);
            //animation
            countUp += Time.deltaTime;
            if (countUp >= 3.0f)
            {
                s = GameState.GAMECOUNTDOWN;
                countUp = 0.0f;
            }
        }
        else if (s == GameState.GAMECOUNTDOWN)
        {
            Debug.Log("game play");
            Debug.Log(countUp);
            countUp += Time.deltaTime;
            if (countUp >= endTime)
            {
                s = GameState.GAMEOVER;
                countUp = 0.0f;
            }
        }
        else if (s == GameState.GAMEOVER)
        {
            Debug.Log("game over");
            Debug.Log(countUp);
            countUp += Time.deltaTime;
            if (countUp >= 3.0f)
            {
                s = GameState.MAINMENU;
                countUp = 0.0f;
            }
        }


    }
}