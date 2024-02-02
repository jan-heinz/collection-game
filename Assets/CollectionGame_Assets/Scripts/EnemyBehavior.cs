using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    public Transform player;

    public float moveSpeed = 10.0f;

    public AudioClip enemySFX;
    // Start is called before the first frame update
    void Start() {
        // if player isn't specified in the inspector
        // try to find it.
        if (player == null) {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!LevelManager.isGameOver) {
            //transform.LookAt(player);
            transform.Rotate(Vector3.forward, 360 * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
            // do the following if the game isn't over
            RotateEnemy();
            FollowPlayer();
        }
       
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

    private void OnCollisionEnter(Collision collision) {
        // if the player is hit by an enemy, end the game
        // destroy the player.
        if (collision.gameObject.CompareTag("Enemy")) {
            AudioSource.PlayClipAtPoint(enemySFX, Camera.main.transform.position);
            Destroy(gameObject);

        }
    }
}
