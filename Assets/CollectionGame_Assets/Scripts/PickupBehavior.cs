using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name + " hit me!");
        // Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.name + " triggered me");
    }
}

