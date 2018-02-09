using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public GameObject gum;
    public GameObject bakutiku;
    public GameObject dog;
    public GameObject coin;

    bool gumflag;
    bool bakutikuflag;
    bool dogflag;
    bool coinflag;

    public float gumtime = 2.0f;
    public float bakutikutime = 2.0f;
    public float dogtime = 2.0f;
    public float cointime = 2.0f;

  


    // Use this for initialization
    void Start () {
        gumflag = false;
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
                    if (gumflag && gumtime <= 0) {
                        Instantiate(gum, ScreenPoint, Quaternion.identity);

                        gumtime = 2.0f;
                    }
                    else if (bakutikuflag && bakutikutime <= 0) {
                        Instantiate(bakutiku, ScreenPoint, Quaternion.identity);

                        bakutikutime = 2.0f;

                    }
                    else if (dogflag && dogtime <= 0) {
                        Instantiate(dog, ScreenPoint, Quaternion.identity);

                        dogtime = 2.0f;

                    }
                    else if (coinflag && cointime <= 0) {
                        Instantiate(coin, ScreenPoint, Quaternion.identity);

                        cointime = 2.0f;

                    }
                }
            }
        }
    }


    void ItemTimer() {
        gumtime -= Time.deltaTime;
        bakutikutime -= Time.deltaTime;
        dogtime -= Time.deltaTime;
        cointime -= Time.deltaTime;
    }

    public void Gamu() {
        gumflag = true;
        bakutikuflag = false;
        dogflag = false;
        coinflag = false;
    }

    public void Bakutiku() {
        bakutikuflag = true;
        gumflag = false;
        dogflag = false;
        coinflag = false;
    }

    public void Dog() {
        dogflag = true;
        gumflag = false;
        bakutikuflag = false;
        coinflag = false;
    }

    public void Coin() {
        coinflag = true;
        gumflag = false;
        bakutikuflag = false;
        dogflag = false;
    }
}
