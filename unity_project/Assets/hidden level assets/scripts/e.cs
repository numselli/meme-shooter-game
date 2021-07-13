using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class e : MonoBehaviour {
 public void Goback () {
        SceneManager.LoadScene(8);
    }
    public void W()
    {
        FindObjectOfType <level_manager> ().Gold =+ GameObject.Find("playera").GetComponent<h>().coins;// add coins to gold
        Debug.Log ("adding");

        FindObjectOfType<level_manager>().coinlevel += 1;//limit Access
        Debug.Log("limiting usage");

        GameObject.Find("GameObject").GetComponent<savecontrol>().SaveProgres();//save
        Debug.Log("saving");

        SceneManager.LoadScene(8);//exit
        Debug.Log("exiting");
    }
}