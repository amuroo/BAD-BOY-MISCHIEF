using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {
    private string evaluation;
    public Text evatext;
    public Text Score;
    private int x;
    public Text Teacher;
    public Text PTTeacher;
    public Text ScienceTeacher;
    public Text kyoutou;
    public Text HeadTeacher;
    public Text In;

    // Use this for initialization
    void Start () {
        GameDirector.score = 50;
        Score.text = GameDirector.score.ToString();
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

        Teacher.text = sensei.TeacherD.ToString();
        PTTeacher.text = sensei.PTTeacherD.ToString();
        ScienceTeacher.text = sensei.ScienceTeacherD.ToString();
        kyoutou.text = sensei.kyoutouD.ToString();
        HeadTeacher.text = sensei.HeadTeacherD.ToString();
        In.text = sensei.In.ToString();
    }

}
