using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

    public GameObject[] enemy;
    public float time;

    //湧きポジの指定
    public Vector2[] Gpos = { new Vector2(-405, 1000), new Vector2(-135, 1000),
                              new Vector2(135, 1000), new Vector2(405, 1000) };
    
    // Use this for initialization
    void Start()
    {
        StartCoroutine("Generate");
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


    }
}
