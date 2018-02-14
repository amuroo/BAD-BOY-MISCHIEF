using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {
    private float time = 1.0f;
    public Text timeText;
    public static int score = 0;
    public Text scoretext;


    void Update() {
        time = Mathf.Min(0.0f, time);
        time -= Time.deltaTime;
        timeText.text = time.ToString("F2");

        scoretext.text = score.ToString();

        if (time <= 00.0f) {
            //SceneManager.LoadScene("Result");

        }

    }

    public void AddScore(int amount) {
        score += amount;
       
    }
}
