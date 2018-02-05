using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject gamu;
    public GameObject bakutiku;
    bool gamuflag;
    bool bakutikuflag;

    public float gamutime = 2.0f;
    public float bakutikutime = 2.0f;

        

    // Use this for initialization
    void Start () {
        gamuflag = false;
        bakutikuflag = false;


    }

    // Update is called once per frame
    void Update() {

        ItemTimer();
        ScreenTouch();

      
    }

    void ScreenTouch() {
        if (Input.touchCount > 0) {
            if (Input.GetTouch(0).phase == TouchPhase.Began) {
                Vector3 ScreenPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                ScreenPoint.z = 1.0f;
                //print(ScreenPoint);

                if (ScreenPoint.y >= -600) {
                    if (gamuflag && gamutime <= 0) {
                        Instantiate(gamu, ScreenPoint, Quaternion.identity);

                        gamutime = 2.0f;
                    }

                    else if (bakutikuflag) {
                        Instantiate(bakutiku, ScreenPoint, Quaternion.identity);

                    }
                }
            }
        }
    }


    void ItemTimer() {
        gamutime -= Time.deltaTime;
        bakutikutime -= Time.deltaTime;
    }

    public void Gamu() {
        gamuflag = true;
        bakutikuflag = false;
    }

    public void Bakutiku() {
        bakutikuflag = true;
        gamuflag = false;
    }
}
