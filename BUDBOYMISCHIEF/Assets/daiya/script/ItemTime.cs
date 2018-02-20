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
            GumCal();
        
        if (this.gameObject.tag == "DogButton") 
            DogCal();
        
        if (this.gameObject.tag == "CoinButton") 
            CoinCal();
 
    }


    void BakutikuCal() {
        if (UIobj.fillAmount > 0) {
            UIobj.fillAmount -= 1.0f / 2.5f * Time.deltaTime;
        }

        if (playercs.bakutikutime == 2.5f) {
            UIobj.fillAmount = 1.0f;
        }
    }

    void GumCal() {
        if (UIobj.fillAmount > 0) {
            UIobj.fillAmount -= 1.0f / 2.0f * Time.deltaTime;
        }

        if (playercs.gumtime == 2.0f) {
            UIobj.fillAmount = 1.0f;
        }
    }

    void DogCal() {
        if (UIobj.fillAmount > 0) {
            UIobj.fillAmount -= 1.0f /5.0f * Time.deltaTime;
        }

        if (playercs.dogtime == 5.0f) {
            UIobj.fillAmount = 1.0f;
        }
    }

    void CoinCal() {
        if (UIobj.fillAmount > 0) {
            UIobj.fillAmount -= 1.0f / 5.0f * Time.deltaTime;
        }
        if (playercs.cointime == 5.0f) {
            UIobj.fillAmount = 1.0f;
        }
    }
}
