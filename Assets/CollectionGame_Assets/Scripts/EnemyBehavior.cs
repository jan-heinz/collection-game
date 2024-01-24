using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // if player isn't specified in the inspector
        // try to find it.
    }

    // Update is called once per frame
    void Update()
    {
        // do the following if the game isn't over
        RotateEnemy();
        FollowPlayer();
    }

    void RotateEnemy()
    {
        // apply full rotation the enemy in the forward direction every second
    }

    void FollowPlayer()
    {
        // move toward the player smoothly
        // moveSpeed should be adjustable through the inspector
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if enemies collide with one another, destroy them
        // play an audio clip before destroying at camera
    }
}
