using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class levelselect : MonoBehaviour {
	
	public GameObject[] buttons;
	public GameObject loading;
    public GameObject cedits;
    public int level2;
    public AudioClip[] clips;
    private AudioSource audiosource;

    public void Start (){
        audiosource = FindObjectOfType<AudioSource>();
        audiosource.loop = false;
        level2 = FindObjectOfType<level_manager>().currentlevel;
        for (int i = 0; i < level2; i++) {
			buttons [i].SetActive (true);

        }
	}

    private AudioClip GetrandomClip()
    {
        return clips[Random.Range(0, clips.Length)];
    }
    void Update()
    {
        if (!audiosource.isPlaying)
        {
            audiosource.clip = GetrandomClip();
            audiosource.Play();
        }
    }
    public void LoadScene(int level){
		loading.SetActive (true);
		SceneManager.LoadScene(level);
	}
    public void exit()
    {
        Application.Quit();
    }
    public void credits(){
        cedits.SetActive (true);
    }
    public void cr()
    {
        cedits.SetActive(false);
    }
}
