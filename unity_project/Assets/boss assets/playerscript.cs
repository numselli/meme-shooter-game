using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerscript : MonoBehaviour {
    public GameObject LaserPrefab;
    public int speed = 6;
    public int health = 10;
    public GameObject L;
    public Text playerhealth;

    public GameObject player1;
    public GameObject player2;
    // Use this for initialization
    void Start () {
        if (FindObjectOfType<level_manager>().anamatedplayer == 1)
        {
            player1.SetActive(false);
            player2.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
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
            Instantiate(LaserPrefab, transform.position, Quaternion.identity);
        }
        if (health <= 0)
        {
            L.SetActive(true);
        }
        playerhealth.text = "Health: " + health.ToString();
        }
}
