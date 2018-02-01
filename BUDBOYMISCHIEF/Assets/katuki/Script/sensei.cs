using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensei : MonoBehaviour
{
    public float x = 1;
    private float time;
    //private Rigidbody2D rb2d;
    private bool stan = false;
    private float xx;
    private bool baku = false;
    private Animator anim;
    private float X = 0;
    private float senseiX;
    private float kaneX;
    // Use this for initialization
    void Start()
    {
        xx = x;
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(X);
        transform.Translate(new Vector2(X, xx * -10));
        if (stan || baku)
        {
            time += Time.deltaTime;
            if (stan && time >= 3)
            {
                stan = false;
                xx = x;
                anim.SetBool("break", false);
            }
            else if (baku && time >= 1)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        print("A"); if (other.gameObject.tag == "Bakuchiku")
        {
            xx = 0;
            anim.SetBool("break", true);
            baku = true;
            //Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Gamu")
        {
            time = 0;
            xx = 0;
            stan = true;
            anim.SetBool("break", true);
        }
        else if (other.gameObject.tag == "Dog")
        {
            anim.SetBool("nige", true);
            xx = -1.5f;
        }
        /*else if (other.gameObject.tag == "kane")
        {
            kaneX = other.gameObject.transform.position.x;
            senseiX = transform.position.x;
            Debug.Log(kaneX);
            if (kaneX > senseiX + 1)
            {
                while (kaneX != senseiX)
                {
                    X = 5;
                }
                X = 0;
            }
            else if (kaneX < senseiX - 1)
            {
                while (kaneX != senseiX)
                {
                    X = -5;
                }
                X = 0;
            }
        }*/
    }

    void OnTriggerStay2D(Collider2D other)
    {
        senseiX = transform.position.x;
        
    }
}


