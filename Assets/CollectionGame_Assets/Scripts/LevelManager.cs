using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public float levelDuration = 10.0f;

    float countDown;
    // Start is called before the first frame update
    void Start() {
        countDown = levelDuration;

    }

    // Update is called once per frame
    void Update() {
        if (countDown > 0) {
            countDown -= Time.deltaTime;
        }
        else {
            countDown = 0.0f;
        }
        
    }

    void OnGUI() {
        GUI.Box(new Rect(10, 10, 50, 30), countDown.ToString("0.00"));
    }
}
