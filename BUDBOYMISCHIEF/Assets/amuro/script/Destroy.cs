using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroy : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		if(obj.transform.position.y <= -1000)
        {
            Destroy(obj);
        }
	}
}
