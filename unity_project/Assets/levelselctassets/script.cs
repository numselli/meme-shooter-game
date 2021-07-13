using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class script : MonoBehaviour {
    public GameObject secret;
    public GameObject onebutton;
    public int kii;
    

    public void Un(){
        if (kii == 4)
        {
            onebutton.SetActive(false);
        }
        secret.SetActive(false);
    }
    public void One()
    {
        SceneManager.LoadScene(9);

    }
    public void two()
    {
       // SceneManager.LoadScene(8);

    }
    public void tree()
    {
       // SceneManager.LoadScene(8);

    }
    public void Back()
    {
        SceneManager.LoadScene(0);

    }
}
 