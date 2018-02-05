using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour {
    private float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()  
    {
        transform.Translate(new Vector2(0, 10 * speed));
        if (transform.position.y >= 1500 || transform.position.y <= -1500)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "scientist")
        {
            speed = -1.5f;
            Debug.Log("PPPPP");
        }
    }
}
