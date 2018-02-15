using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToStart()
    {
        Invoke("GoScene", 1);
    }

    public void Tutorial()
    {
        Invoke("GoTutorial", 0.5f);
    }

  private void GoScene()
    {
        //SceneManager.LoadScene("hogehoge");
        Debug.Log("ToStart");
    }

   private void GoTutorial()
    {
        //SceneManager.LoadScene("hogehoge");
        Debug.Log("ToTutorial");
    }
}
