using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemTime : MonoBehaviour {
    public Image UIobj;
 
    Player playercs;


    // Use this for initialization
    void Start () {
        
        playercs = GameObject.FindWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.tag == "BakutikuButton") 
            BakutikuCal();
        
        if (this.gameObject.tag == "GumButton") 
            GamuCal();
        
        if (this.gameObject.tag == "DogButton") 
            DogCal();
        
        if (this.gameObject.tag == "CoinButton") 
            CoinCal();
 
    }


    void BakutikuCal() {
        if (UIobj.fillAmount > 0) {
            UIobj.fillAmount -= 1.0f / playercs.bakutikutime * Time.deltaTime;
        }


            if (UIobj.fillAmount < 0) {
                UIobj.fillAmount = 1.0f;
            }
        

    }
    void GamuCal() {
        print("a");
        if (UIobj.fillAmount > 0) {
            UIobj.fillAmount -= 1.0f / playercs.gumtime * Time.deltaTime;
        }
        if (UIobj.fillAmount == 0) {
            UIobj.fillAmount = 1.0f;
        }


    }
    void DogCal() {
        if (UIobj.fillAmount > 0) {
            UIobj.fillAmount -= 1.0f / playercs.dogtime * Time.deltaTime;
        }

    }
    void CoinCal() {
        if (UIobj.fillAmount > 0) {
            UIobj.fillAmount -= 1.0f / playercs.cointime * Time.deltaTime;
        }

    }
}
