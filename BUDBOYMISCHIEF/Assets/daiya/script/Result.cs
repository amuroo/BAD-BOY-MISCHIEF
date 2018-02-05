using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {
    private string evaluation;
    Text evatext;

    // Use this for initialization
    void Start () {
        evatext = this.gameObject.GetComponent<Text>();

        if (GameDirector.score >= 100) {
            evaluation = "星3つ";

        }
        else if (GameDirector.score >= 50) {
            evaluation = "星2つ";


        }
        else if (GameDirector.score >= 30) {
            evaluation = "星1つ";


        }

        evatext.text = evaluation;

     

    }

}
