using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_manager : MonoBehaviour {
	public int currentlevel = 0;
    public int Gold;
    public int coinlevel;
    public int[] ff;
    public int anamatedplayer;


    void Start()
    {
        DontDestroyOnLoad(gameObject);
        ff = new int[4];
    }
}
