using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tryanglespin : MonoBehaviour {
    public int speed;
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
