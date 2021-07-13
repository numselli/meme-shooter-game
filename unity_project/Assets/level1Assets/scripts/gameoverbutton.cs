using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gameoverbutton : MonoBehaviour
{
	void start(){
		

	}
	public void LoadScene(int level){
		
		SceneManager.LoadScene (0);

	}
}