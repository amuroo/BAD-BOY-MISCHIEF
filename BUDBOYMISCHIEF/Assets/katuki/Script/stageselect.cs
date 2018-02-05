using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class stageselect : MonoBehaviour {
    public int ClearStage = 0;
    private int x = 0;
	// Use this for initialization
	void Start () {
        x = PlayerPrefs.GetInt("ClearStage");
        print(x);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            PlayerPrefs.SetInt("ClearStage", 0);
            x = 0;
            Debug.Log("RESET CLER STAGE");
        }
	}

    public void Stage1()
    {
        SceneManager.LoadScene("testStage1");
        Debug.Log("GO to Stage1");
    }

    public void Stage2()
    {
        if (x >= 1)
        {
            //SceneManager.LoadScene("stage2");
            Debug.Log("GO to Stage2");
        }
    }

    public void Stage3()
    {
        if (x >= 2)
        {
            //SceneManager.LoadScene("stage3");
            Debug.Log("GO to Stage3");
        }
    }

    public void Stage4()
    {
        if (x >= 3)
        {
            //SceneManager.LoadScene("stage4");
            Debug.Log("GO to Stage4");
        }
    }

    public void Stage5()
    {
        if (x >= 4)
        {
            //SceneManager.LoadScene("stage5");
            Debug.Log("GO to Stage5");
        }
    }
}
