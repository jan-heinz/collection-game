using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 2f;
    Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        // get a reference to the rigidbody component
        rigidBody = GetComponent<Rigidbody>();
        //rigidBody.AddForce(transform.forward * 5);
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 forceVector = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidBody.AddForce(forceVector * speed);
    } 
    

    void ControlPlayer()
    {
        // get and store horizontal and vertical input

        // declare a forceVector based on h and v inputs

        // apply force to the rigidbody using forceVector
    }
}
