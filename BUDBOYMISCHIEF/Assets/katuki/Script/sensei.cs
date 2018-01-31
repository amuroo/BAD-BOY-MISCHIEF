using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensei : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float x = 1;
    private float time;
    private bool stan = false;
    private float R;
    private float xx;
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        xx = x;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate ( new Vector2(0, xx * -10));
        if (stan)
        {
            time += Time.deltaTime;
            if(time >= 3)
            {
                stan = false;
                xx = x;
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
            xx = 0;
            stan = true;
        }else if(other.gameObject.tag == "Dog")
        {
            xx = -1.5f;
        }
    }
}
