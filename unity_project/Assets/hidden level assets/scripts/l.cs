using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l : MonoBehaviour {
    public GameObject boom;

    void Update()
    {
        transform.Translate(new Vector2(0, 5) * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
    Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "enemy")
        {
            GameObject.Find("playera").GetComponent<h>().coins += 25;
            Instantiate(boom, transform.position, Quaternion.Euler(90, 0, 0));
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }

        if (coll.gameObject.tag == "astroid")
        {
            Instantiate(boom, transform.position, Quaternion.Euler(90, 0, 0));
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
    }
}
