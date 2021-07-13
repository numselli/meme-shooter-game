using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class buywgoldscript : MonoBehaviour {
    public Button p;
    public Button a;
    public Button q;
    public Text goldtext;
    public AudioSource k;
    public AudioClip h;


    int isspinersold;

    public Text spinerPrice;

    void Start()
    {
        if (PlayerPrefs.GetInt("IsRifleSold") >= 2)
        {
            print("IsRifleSold is grater than 2");
        }
    }
    public void one()
	{
        FindObjectOfType<level_manager>().Gold -= 100;
        FindObjectOfType<level_manager>().anamatedplayer ++;
        //FindObjectOfType<level_manager>().Gold -= 100;
        PlayerPrefs.SetInt("IsRifleSold", 1);
        p.interactable = (false);

    }
    public void two()
    {
        FindObjectOfType<level_manager>().Gold -= 100;
    }
    public void three()
    {
        FindObjectOfType<level_manager>().Gold -= 100;
    }
    public void audio()
    {
        k.PlayOneShot(h);
    }
    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
    }

    // Update is called once per frame
    void Update () {

        //if (FindObjectOfType<level_manager>().Gold >= 100)
        //{
        //    //p.interactable = true;
        //    print("1 open");
        //}
        //if (FindObjectOfType<level_manager>().Gold >= 200)
        //{
        //    //a.interactable = true;
        //    print("2 open");

        //}
        //if (FindObjectOfType<level_manager>().Gold >= 300)
        //{
        //    print("3 open");

        //    //q.interactable = true;
        //}
        goldtext.text = "Gold: " + FindObjectOfType<level_manager>().Gold.ToString();

    }

}