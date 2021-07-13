using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d : MonoBehaviour {
    void Update()
    {
        transform.Translate(Vector2.down * 5 * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
       // GameObject.Find("player").GetComponent<player>().score -= 5;


    }
}
