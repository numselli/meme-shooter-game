using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour {
    public GameObject LaserPrefab;
    public int spead;
    public int health = 10;
    public Slider healthbar;
    public GameObject win;

    public float x;
    public float y;
    // Use this for initialization
    void Start () {
        InvokeRepeating("shoot", 0f, 1f);
        InvokeRepeating("move", 0f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health;
        if (health == 0)
        {
            win.SetActive(true);
            Destroy(gameObject);
        }
       y = gameObject.transform.position.y;
       x = gameObject.transform.position.x;

       

    }
    public void move ()
    {
        Vector3 temppPos = transform.position;
        temppPos.x = Random.Range(0, 10);
        temppPos.y = Random.Range(0, 10);
        transform.position = temppPos;

    }
    public void shoot () {
       Instantiate(LaserPrefab, transform.position, Quaternion.identity);
   }
}
