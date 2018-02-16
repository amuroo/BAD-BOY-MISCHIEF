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

    //追加　評価の星
    public GameObject eva_star0;
    public GameObject eva_star1;
    public GameObject eva_star2;

    // Use this for initialization
    void Start () {
        GameDirector.score -= sensei.In * 10;
        EvaCal();

        //追加
        eva_star0.SetActive(false);
        eva_star1.SetActive(false);
        eva_star2.SetActive(false);

        Pop.SetActive(false);
        
        Score.text = GameDirector.score.ToString();
        
        evatext.text = evaluation;

        Teacher.text = "×　" + sensei.TeacherD.ToString();
        PTTeacher.text = "×　" + sensei.PTTeacherD.ToString();
        ScienceTeacher.text = "×　" + sensei.ScienceTeacherD.ToString();
        kyoutou.text = "×　" + sensei.kyoutouD.ToString();
        HeadTeacher.text = "×　" + sensei.HeadTeacherD.ToString();
        In.text = "通した数　" + sensei.In.ToString();
    }

    void Update() {
        if(Input.touchCount > 0) {
            Pop.SetActive(true);
        }
    }

    public void EvaCal() {
        switch (GameDirector.clearstage) {
            case "Stage1":               
                if (GameDirector.score >= 100) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                    eva_star2.SetActive(true);
                }
                else if (GameDirector.score >= 50) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                }
                else if (GameDirector.score < 50) {

                    eva_star0.SetActive(true);
                }
                break;

            case "Stage2":
                if (GameDirector.score >= 150) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                    eva_star2.SetActive(true);
                }
                else if (GameDirector.score >= 100) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                }
                else if (GameDirector.score < 100) {

                    eva_star0.SetActive(true);
                }
                break;

            case "Stage3":
                if (GameDirector.score >= 150) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                    eva_star2.SetActive(true);
                }
                else if (GameDirector.score >= 100) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                }
                else if (GameDirector.score < 100) {

                    eva_star0.SetActive(true);
                }
                break;

            case "Stage4":
                if (GameDirector.score >= 180) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                    eva_star2.SetActive(true);
                }
                else if (GameDirector.score >= 130) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                }
                else if (GameDirector.score < 130) {

                    eva_star0.SetActive(true);
                }
                break;

            case "Stage5":
                if (GameDirector.score >= 200) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                    eva_star2.SetActive(true);
                }
                else if (GameDirector.score >= 150) {

                    eva_star0.SetActive(true);
                    eva_star1.SetActive(true);
                }
                else if (GameDirector.score < 150) {

                    eva_star0.SetActive(true);
                }
                break;
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
