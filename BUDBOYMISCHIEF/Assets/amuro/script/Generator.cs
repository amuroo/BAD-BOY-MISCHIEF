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
            GameObject element = enemy[Random.Range(0, enemy.Length)];
            Instantiate(element, Gpos[Random.Range(0, Gpos.Length)], Quaternion.identity);
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

    }
}
