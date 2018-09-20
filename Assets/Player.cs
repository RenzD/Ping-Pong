using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Indicator for left / right players
 */
public enum ePlayer
{
    Left,
    Right
}

public class Player : MonoBehaviour {

    public float speed = 15f;   //Speed of the player along the y-axis
    public ePlayer player;      // Left or Right player indicator
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start () {
		
	}

    // Updates player position
    void FixedUpdate()
    {
        //Checks for player left or right and changes speed
        float inputSpeed = 0f;
        if (player == ePlayer.Left)
        {
            inputSpeed = Input.GetAxisRaw("Player1");
            //inputSpeed = Input.GetAxisRaw("PlayerJoystick");
        } else if (player == ePlayer.Right)
        {
            inputSpeed = Input.GetAxisRaw("Player2");
        }

        //moveDirection = new Vector3 (0f, Input.GetAxisRaw("PlayerJoystick"), 0f);

        //transform.position += moveDirection;

        // Changes player position in the y-axis
        transform.position += new Vector3(0f, inputSpeed * speed * Time.deltaTime, 0f);
    }
}
