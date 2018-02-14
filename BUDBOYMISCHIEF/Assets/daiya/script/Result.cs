using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    public GameObject Pop;

    // Use this for initialization
    void Start () {

        Pop.SetActive(false);

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

    void Update() {
        if(Input.touchCount > 0) {
            Pop.SetActive(true);
        }
    }

    public void Gotitle() {
        SceneManager.LoadScene("Title");
    }

    public void Gonext() {
        if (GameDirector.clearstage == "Stage1") {
            SceneManager.LoadScene("Stage2");
        }
        else if (GameDirector.clearstage == "Stage2") {
            SceneManager.LoadScene("Stage3");
        }
        else if (GameDirector.clearstage == "Stage3") {
            SceneManager.LoadScene("Stage4");
        }
        else if (GameDirector.clearstage == "Stage4") {
            SceneManager.LoadScene("Stage5");
        }
                
           

        
      
        
    }

    public void Gorestart() {
        SceneManager.LoadScene(GameDirector.clearstage);
    }

}
