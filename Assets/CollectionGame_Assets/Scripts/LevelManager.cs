using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public float levelDuration = 10.0f;
    public Text timerText;
    public static bool isGameOver = false;
    
    float countDown;
    // Start is called before the first frame update
    void Start() {
        countDown = levelDuration;

        SetTimerText();

    }

    // Update is called once per frame
    void Update() {
        if (!isGameOver) {
            if (countDown > 0) {
                countDown -= Time.deltaTime;
            } else {
                countDown = 0.0f;
                isGameOver = true;
                // LevelLost()
            } 
        } 
        SetTimerText(); 
    }

    void OnGUI() {
        //GUI.Box(new Rect(10, 10, 50, 30), countDown.ToString("0.00"));
    }

    void SetTimerText() {
        timerText.text = countDown.ToString("f2");

    }
}
