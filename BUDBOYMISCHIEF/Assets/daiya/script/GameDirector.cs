﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameDirector : MonoBehaviour {
    public float gametime = 60.0f;
    public Text timeText;
    public static int score = 0;
    public Text scoretext;
    public static string clearstage;


    void Start() {
        score = 0;
        clearstage = null;
        sensei.TeacherD = 0;
        sensei.TeacherD = 0;
        sensei.TeacherD = 0;
        sensei.TeacherD = 0;
        sensei.TeacherD = 0;
        sensei.In = 0;

        clearstage = SceneManager.GetActiveScene().name;
    }
    void Update() {
        gametime -= Time.deltaTime;
        timeText.text = gametime.ToString("F1");

        scoretext.text = score.ToString();

        if (gametime < 0) {
            gametime = 0;
            
            ClearStage(clearstage);
            SceneManager.LoadScene("Result");
        }
    }

    public void AddScore(int amount) {
        score += amount;    
    }

    public void ClearStage(string stage) {
        if (PlayerPrefs.GetInt("ClearStage") < 1 && stage=="Stage1") {
            PlayerPrefs.SetInt("ClearStage", 1);
        }
        else if (PlayerPrefs.GetInt("ClearStage") < 2 && stage == "Stage2") {
            PlayerPrefs.SetInt("ClearStage", 2);
        }
        else if (PlayerPrefs.GetInt("ClearStage") < 3 && stage == "Stage3") {
            PlayerPrefs.SetInt("ClearStage", 3);
        }
        else if (PlayerPrefs.GetInt("ClearStage") < 4 && stage == "Stage4") {
            PlayerPrefs.SetInt("ClearStage", 4);
        }
        else if (PlayerPrefs.GetInt("ClearStage") < 5 && stage == "Stage5") {
            PlayerPrefs.SetInt("ClearStage", 5);
        }
    }
}
