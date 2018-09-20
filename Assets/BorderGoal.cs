using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BorderGoal : MonoBehaviour {
    

    public ePlayer player;  //Indicator for left / right
    /// <summary>
    /// Reference to the score ui.
    /// </summary>
    //public ScoreUI score;
    public Score score;
    

    void Start()
    {
    }

    /// <summary>
    /// Invoked by Unity if a GameObject collides with this GameObject.
    /// </summary>
    void OnCollisionEnter(Collision col)
    {
        // Has the GameObject that collides the Ball component?
        Ball ball = col.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            // Resets ball position
            // Then, set the impulse to the ball
            ball.transform.position = new Vector3(0f, 0f, 0f);
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().AddForce(ball.getInitialImpulse(), ForceMode.Impulse);

            // increment score of the other player

            if (player == ePlayer.Right)
                score.score1++;
            //score.scorePlayerLeft++;
            else if (player == ePlayer.Left)
                score.score2++;
            //score.scorePlayerRight++;

        }
    }
}
