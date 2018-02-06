using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject[] enemy;
    public float time;
    public bool plus = false;
    float count;
    float interval;
    public float div;
    private int randomNum;
    public int[] par;


    //湧きポジの指定
    public Vector2[] Gpos = { new Vector2(-405, 1000), new Vector2(-135, 1000),
                              new Vector2(135, 1000), new Vector2(405, 1000) };
    
    // Use this for initialization
    void Start()
    {
        StartCoroutine("Generate");
        plus = true;
    }

    IEnumerator Generate()
    {
        while (true)
        {
            //配列の中からランダムで生成
            randomNum = Random.Range(1,101);
            GameObject element = enemy[Random.Range(0, enemy.Length)];
            if (randomNum <= par[0])
            {
                Instantiate(enemy[0], Gpos[Random.Range(0, Gpos.Length)], Quaternion.identity);
            } else if((randomNum > par[0]) && (randomNum <= par[1]))
            {
                Instantiate(enemy[1], Gpos[Random.Range(0, Gpos.Length)], Quaternion.identity);
            } else if((randomNum > par[1]) && (randomNum <= par[2]))
            {
                Instantiate(enemy[2], Gpos[Random.Range(0, Gpos.Length)], Quaternion.identity);
            } else if((randomNum > par[2]) && (randomNum <= par[3]))
            {
                Instantiate(enemy[3], Gpos[Random.Range(0, Gpos.Length)], Quaternion.identity);
            } else if((randomNum > par[3]) && (randomNum <= par[4]))
            {
                Instantiate(enemy[4], Gpos[Random.Range(0, Gpos.Length)], Quaternion.identity);
            }

            yield return new WaitForSecondsRealtime(time);
        }
    }
    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        interval += Time.deltaTime;

        if (plus)
        {
            time -= (interval /= div);
        }

        if(count > 60f)
        {
            StopCoroutine("Generate");
            plus = false;
        }

        // Debug.Log(time);
        Debug.Log(count);
        Debug.Log(randomNum);

    }
}
