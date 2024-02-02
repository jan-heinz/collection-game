using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour {
    public float speed = 2f;
    public float jumpForce = 5f;
    Rigidbody rigidBody;
    AudioSource jumpSFX;

    // Start is called before the first frame update
    void Start()
    {
        // get a reference to the rigidbody component
        rigidBody = GetComponent<Rigidbody>();
        jumpSFX = GetComponent<AudioSource>();
        //rigidBody.AddForce(transform.forward * 5);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (transform.position.y < 1.1f) {
                rigidBody.AddForce(0, jumpForce, 0, ForceMode.Impulse);
                jumpSFX.Play();
            }
        }
    }

    private void FixedUpdate() {
        if (!LevelManager.isGameOver) {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 forceVector = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rigidBody.AddForce(forceVector * speed);
        }
        else {
            rigidBody.velocity = Vector3.zero;
            rigidBody.angularVelocity = Vector3.zero;
        }
       

       
    } 
    

    void ControlPlayer()
    {
        // get and store horizontal and vertical input

        // declare a forceVector based on h and v inputs

        // apply force to the rigidbody using forceVector
    }
}
