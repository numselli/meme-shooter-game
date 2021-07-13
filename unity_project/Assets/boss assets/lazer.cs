using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
            FindObjectOfType<Enemy>().health -= 1;
            Destroy(gameObject);

        }
        if (coll.gameObject.tag == "enemyL")
        {
            Destroy(gameObject);
            Destroy(coll.gameObject);

        }

    }
}
