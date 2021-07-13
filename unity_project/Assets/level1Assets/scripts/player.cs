using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject LaserPrefab;
	public Text hText;
	public Text sText;
	public GameObject win;
	public Button nextlevel;
	public GameObject gameovertxt;
	public Button gameover;
	public GameObject cat;
	public int score = 0;
	public int health = 10;
	public int speed = 6;

    public GameObject player1;
    public GameObject player2;


    public void Start(){
        if (FindObjectOfType<level_manager>().anamatedplayer == 1)
        {
            player1.SetActive(false);
            player2.SetActive(true);
        }
    }

    private void Update()
    {
		if (score >= 50) {
			FindObjectOfType <level_manager> ().currentlevel += 1;//un hide when level2 is made
			win.SetActive (true);
			nextlevel.interactable = true;
			cat.SetActive (true);
			
			Destroy(gameObject);

		}


		hText.text = "Health: " + health.ToString ();
		sText.text = "Score: " + score.ToString ();
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector2(0, speed) * Time.deltaTime);

		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector2(0, - speed) * Time.deltaTime);

		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector2(-speed, 0) * Time.deltaTime);

		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector2(speed, 0) * Time.deltaTime);

        }
		if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate (LaserPrefab , transform.position , Quaternion.identity);
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
			hText.text = "Health: " + 0.ToString ();
			gameovertxt.SetActive (true);
			gameover.interactable = true;
			Destroy(gameObject);
		}

		if (collision.transform.tag == "enemy") {
			Destroy (collision.gameObject);
		}

	}

}