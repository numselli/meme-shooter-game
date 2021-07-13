using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g : MonoBehaviour {
    public GameObject gggg;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("jjj", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void jjj()
    {
        Vector2 RandomPosition = new Vector2(Random.Range(-11f, 11f), transform.position.y);
        Instantiate(gggg, RandomPosition, Quaternion.identity);
    }


}
