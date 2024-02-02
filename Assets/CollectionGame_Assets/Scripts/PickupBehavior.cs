using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour {

    public static int pickupCount = 0;

    public AudioClip pickupSFX;
    // Start is called before the first frame update
    void Start() {
        pickupCount++;
        Debug.Log("Pickup count: " + pickupCount);
    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name + " hit me!");
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log(other.gameObject.name + " triggered me");
        AudioSource.PlayClipAtPoint(pickupSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }

    private void OnDestroy() {
        if (!LevelManager.isGameOver) {
            pickupCount--;
            Debug.Log("Pickup remaining: " + pickupCount);

            if (pickupCount <= 0) {
                Debug.Log("You win!"); 
                
                FindObjectOfType<LevelManager>().LevelBeat();
            }
        }
    }
}

