using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class j : MonoBehaviour {

    public GameObject sss;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("fff", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void fff()
    {
        Vector2 RandomPosition = new Vector2(Random.Range(-11f, 11f), transform.position.y);
        Instantiate(sss, RandomPosition, Quaternion.identity);
    }


}
