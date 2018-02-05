using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {
    private float time = 0;
    public Text timeText;
    public static int score = 0;


    void Update() {
        time += Time.deltaTime;

        timeText.text = time.ToString("F2");

        if (time >= 60.0f) {
            SceneManager.LoadScene("Result");

        }

    }

    public void AddScore(int amount) {
        score += amount;
       
    }
}
