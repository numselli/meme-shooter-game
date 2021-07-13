using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class movedown : MonoBehaviour {
    public int speed = 6;
    // Update is called once per frame
    void Update () {
        transform.Translate(new Vector2(0, -speed) * Time.deltaTime);
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);

    }
}