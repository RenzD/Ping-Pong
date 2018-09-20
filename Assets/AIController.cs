using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

    public Transform ball;

    [Range(0, 1)]
    public float skill;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.y = Mathf.Lerp(transform.position.y, ball.position.y, skill);
        transform.position = newPos;
    }
}
