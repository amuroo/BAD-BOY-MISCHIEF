using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensei : MonoBehaviour
{
    public float speed = 1;
    private float time;//スタン時、撃破時の処理用
    private bool stan = false;
    public float xx;
    private bool baku = false;
    private Animator anim;
    private float X = 0;
    private float senseiX;//先生の位置
    private float kaneX;//お金の位置
    private bool Dog = false;
    public AudioClip Damege;
    public AudioClip Gamu;
    public AudioClip Won;
    public AudioClip Money;
    Player playersc;
    private int recastRan = 0;

    public int teacherscore;
    public int ptteacherrscore;
    public int scienceTeacherscore;
    public int kyoutouscore;
    public int headteacherscore;

    GameDirector gamedirectorsc;

    void Start()
    {
        xx = speed;
        anim = GetComponent<Animator>();
        playersc = GameObject.FindWithTag("Player").GetComponent<Player>();
        gamedirectorsc = GameObject.FindWithTag("GameDirector").GetComponent<GameDirector>();

    }

    void Update()
    {
        if (transform.position.y == -900 /*&& this.gameObject.tag == "kyoutou"*/)
        {
            recastRan = Random.Range(0, 4);
            if (recastRan == 0)
            {
                playersc.gamutime += 1;
                Debug.Log("recastGAMU");
            }
            else if (recastRan == 1)
            {
                playersc.cointime += 1;
                Debug.Log("recastCOIN");
            }
            else if (recastRan == 2)
            {
                playersc.dogtime += 1;
                Debug.Log("recastDOG");

            }
            else if (recastRan == 3)
            {
                playersc.bakutikutime += 1;
                Debug.Log("recastBAKUTIKU");

            }
        }
        transform.Translate(new Vector2(X, xx * -10));
        if (stan || baku )
        {
            time += Time.deltaTime;
            X = 0;
            if (stan && time >= 3)
            {
                stan = false;
                xx = speed;
                anim.SetBool("break", false);
            }
            else if (baku && time >= 1)
            {
                if (this.gameObject.tag == "Teacher") {
                    gamedirectorsc.AddScore(teacherscore);
                }

                else if (this.gameObject.tag == "PTTeacher") {
                    gamedirectorsc.AddScore(ptteacherrscore);
                }

                else if (this.gameObject.tag == "ScienceTeacher") {
                    gamedirectorsc.AddScore(scienceTeacherscore);
                }

                else if (this.gameObject.tag == "kyoutou") {
                    gamedirectorsc.AddScore(kyoutouscore);
                }
                else if (this.gameObject.tag == "HeadTeacher") {
                    gamedirectorsc.AddScore(headteacherscore);
                }
                Destroy(gameObject);

            }
        }
        if(transform.position.y >= 1500 || transform.position.y <= -1500)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bakuchiku")
        {
            GetComponent<AudioSource>().PlayOneShot(Damege);
            xx = 0;
            anim.SetBool("break", true);
            baku = true;
        }
        else if (other.gameObject.tag == "Gamu")
        {
            GetComponent<AudioSource>().PlayOneShot(Gamu);
            time = 0;
            xx = 0;
            stan = true;
            anim.SetBool("break", true);
        }
        else if (other.gameObject.tag == "Dog" && this.gameObject.tag != "scientist")
        {
            GetComponent<AudioSource>().PlayOneShot(Won);
            Dog = true;
            anim.SetBool("nige", true);
            xx = speed * -1 * 1.5f;
        }else if (other.gameObject.tag == "Dog" && this.gameObject.tag == "scientist")
        {
            xx = 0;
        }

    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "kane") //お金に引き寄せられる処理
        {
            if (stan || baku || Dog) return;
            GetComponent<AudioSource>().PlayOneShot(Money);
            senseiX = transform.position.x;//位置を取得
            kaneX = other.gameObject.transform.position.x;//
            if (kaneX == senseiX)
            {
                X = 0;
            }
            else if (kaneX > senseiX)
            {
                X = 5;
            }
            else if (kaneX < senseiX)
            {
                X = -5;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        X = 0;//x座標固定
    }
}


