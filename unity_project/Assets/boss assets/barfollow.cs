using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barfollow : MonoBehaviour {
    public Dictionary<float, GameObject> distDic = new Dictionary<float, GameObject>();
    public Transform objecttransfom;

    //public GameObject ui;
    public GameObject objToTP;
    public Transform tpLoc;
    public GameObject boss;

    // Use this for initialization
    void Start()
    {
      

        objecttransfom = boss.GetComponent<Transform>();

        // Do something with furthestObj
        tpLoc = objecttransfom;
    }


    void Update()
    {
        objToTP.transform.position = tpLoc.transform.position + new Vector3(0, 0, 0);

    }

  
}
