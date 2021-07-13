using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour {

    public GameObject ggg;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 1f);
    }

   

    void SpawnEnemy()
    {
        Vector2 RandomPosition = new Vector2(Random.Range(-11f, 11f), transform.position.y);
        Instantiate(ggg, RandomPosition, Quaternion.identity);
    }
}
