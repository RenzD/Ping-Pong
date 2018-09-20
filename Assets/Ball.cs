using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


    public Vector3 initialImpulse;      //initial impulse to ball when game starts

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(initialImpulse, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "PlayerLeft")
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(1f, 1f, 0), ForceMode.Impulse);
        }
    }

    public Vector3 getInitialImpulse()
    {
        return initialImpulse;
    }
}
