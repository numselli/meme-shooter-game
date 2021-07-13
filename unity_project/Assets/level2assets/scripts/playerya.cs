using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerya : MonoBehaviour {
    public GameObject LaserPrefab;

    public int ghgh = 0;
    public int health = 10;
    public int speed = 6;
    public GameObject winthing;
    public Text sdfg;
    public Text gfgf;

    public GameObject player1;
    public GameObject player2;
    public void Start()
    {
        if (FindObjectOfType<level_manager>().anamatedplayer == 1)
        {
            player1.SetActive(false);
            player2.SetActive(true);
        }
    }

    private void Update()
    {
        sdfg.text = "Score: " + ghgh.ToString();
        gfgf.text = "health: " + health.ToString();


        if (ghgh >= 50)
        {
            winthing.SetActive (true);
            //FindObjectOfType <level_manager> ().currentlevel += 1; un hide when level3 is made
            Destroy(gameObject);

        }


        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0, speed) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -speed) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-speed, 0) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(speed, 0) * Time.deltaTime);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Instantiate (LaserPrefab , transform.position , Quaternion.identity);
        }


    }
}
