using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    static int score;
    private Text Score;



    // Use this for initialization
    void Start() {
        Score = this.gameObject.GetComponent<Text>();
        Score.text = "スコア : " + score;
        score = 0;
    }

    public void AddScore(int amount)
    {
     score += amount;
     Score.text = "スコア : " + score;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
