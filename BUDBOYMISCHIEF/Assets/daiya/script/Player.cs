using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject gamu;
    public GameObject bakutiku;
    bool gamuflag;
    bool bakutikuflag;
 





    // Use this for initialization
    void Start () {
        gamuflag = false;
        bakutikuflag = false;
      

    }

    // Update is called once per frame
    void Update() {

        if (Input.touchCount > 0) {
            if (Input.GetTouch(0).phase == TouchPhase.Began) {
                Vector3 ScreenPoint = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                ScreenPoint.z = 1.0f;
                print(ScreenPoint);

                //Vector3 nowPos = Camera.main.ScreenToWorldPoint(ScreenPoint);
                if (ScreenPoint.y >= -600) {
                    if (gamuflag) {
                        Instantiate(gamu, ScreenPoint, Quaternion.identity);
                    }
                    else if (bakutikuflag) {
                        Instantiate(bakutiku, ScreenPoint, Quaternion.identity);
                    }
                }
            }
        }
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
