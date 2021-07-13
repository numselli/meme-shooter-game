using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
public class h : MonoBehaviour {
    public GameObject LaserPrefab;
    public GameObject win;
    public GameObject L;
    public GameObject cheat;
    public Text hText;
    public Text sText;
    public int coins = 0;
    public int health = 10;
    public int speed = 6;

    public GameObject player1;
    public GameObject player2;
    private void OnBecameInvisible()
    {
        //Destroy(gameObject);
        //cheat.SetActive(true);

    }
    private void Start()
    {
        if (FindObjectOfType<level_manager>().anamatedplayer == 1)
        {
            player1.SetActive(false);
            player2.SetActive(true);
        }
    }

    private void Update()
    {
        if (coins >= 3000)
        {
            //Destroy(gameObject);
            win.SetActive(true);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            L.SetActive(true);
        }

        hText.text = "\t\t\t\tHealth: " + health.ToString();
        sText.text = "Gold Increase: " + coins.ToString();
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
        if (1 == 1)
        {
            Instantiate(LaserPrefab, transform.position, Quaternion.identity);
        }


    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.transform.tag == "astroid")
        {
            health -= 1;
            Destroy(collision.gameObject);
        }

        if (collision.transform.tag == "enemy")
        {
            health -= 1;
            Destroy(collision.gameObject);
        }
        if (health == 0)
        {
            hText.text = "Health: " + 0.ToString();
            L.SetActive(true);
           // gameover.interactable = true;
            Destroy(gameObject);
        }

        if (collision.transform.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }

    }
}