using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensei : MonoBehaviour {
    private Rigidbody2D rb2d;
    private float x = -10;
    private float time;
    private bool stan = false;
    private float R;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate ( new Vector2(0, x));
        if (stan)
        {
            time += Time.deltaTime;
            if(time >= 3)
            {
                stan = false;
                x = -10;
            }
        }
        time += Time.deltaTime;
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bakuchiku")
        {
            Destroy(gameObject);
        }else if(other.gameObject.tag == "Gamu")
        {
            time = 0;
            x = 0;
            stan = true;
        }else if(other.gameObject.tag == "Dog")
        {
            x = 40;
            rb2d.AddTorque(100);
        }
    }
}
