using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour {
    public float speed = 15f;

    // Use this for initialization
    void Start () {
		
	}

    // Updates player position
    void FixedUpdate()
    {
        float inputSpeed = 0f;
        inputSpeed = Input.GetAxisRaw("PlayerJoystick");
        transform.position += new Vector3(0f, inputSpeed * speed * Time.deltaTime, 0f);
    }
}
