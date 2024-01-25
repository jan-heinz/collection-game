using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    GameObject player;
    Vector3 offSet;
    
    // Start is called before the first frame update
    void Start()
    {
        // get and store the offset from the camera to the player
        player = GameObject.FindGameObjectWithTag("Player");
        offSet = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // add the offset to the player's position
        transform.position = player.transform.position + offSet;
        // assign it to the camera's position
    }
}
