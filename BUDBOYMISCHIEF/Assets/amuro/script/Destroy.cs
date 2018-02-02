using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour {

    public GameObject obj;
    public int score = 10;
    private ScoreManager SM;

	// Use this for initialization
	void Start () {
        SM = GameObject.Find("Text").GetComponent<ScoreManager>();
    }
	
	// Update is called once per frame
	void Update () {
		if(obj.transform.position.y <= -1000)
        {
            SM.AddScore(score);
            Destroy(obj);
        }
	}
}
