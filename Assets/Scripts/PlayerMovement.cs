using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Properties
    public Rigidbody body;
    public float moveForce = 500f;
    public float turnForce = 500f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void FixedUpdate() {
        var dt = Time.deltaTime;

        // Add forward force
        body.AddForce(0, 0, moveForce * dt);

        // Input
        if (Input.GetKey("d"))
            body.AddForce(turnForce * dt, 0, 0);

        if (Input.GetKey("a"))
            body.AddForce(-turnForce * dt, 0, 0);
    }
}
