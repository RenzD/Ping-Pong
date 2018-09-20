using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour {

    public Text textScore;
    public Text winMessage;
    public int winScore = 1;
    public int score1 = 0;
    public int score2 = 0;

    // Use this for initialization
    void Start () {
        textScore.text = "Player 1: " + score1 + "\t\t" + "Player 2: " + score2;
	}
	
	// Update is called once per frame
	void Update () {
        textScore.text = "Player 1: " + score1 + "\t\t" + "Player 2: " + score2;

        // Checks conditions if any player won
        if (score1 >= winScore || score2 >= winScore)
        {
            //Disable the ball
            GameObject ball = GameObject.Find("Ball");
            if (ball != null)
            {
                ball.SetActive(false);
            }

            //Check which player won and declare the winner
            if (score1 >= winScore)
            {
                winMessage.text = "PLAYER 1 WINS";
            } else
            {
                winMessage.text = "PLAYER 2 WINS";
            }

        }


    }

}
