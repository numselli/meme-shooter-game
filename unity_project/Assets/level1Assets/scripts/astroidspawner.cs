using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroidspawner : MonoBehaviour
{
    
    public GameObject astroidsowner;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("enemyspawner", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void enemyspawner()
    {
        Vector2 RandomPosition = new Vector2(Random.Range(-11f, 11f), transform.position.y);
        Instantiate(astroidsowner, RandomPosition, Quaternion.identity);
    }


}
