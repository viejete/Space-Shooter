using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour {

    // Bullet Prefab
    public GameObject bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Spawn the bullet
            GameObject g = (GameObject)Instantiate(bullet,
                transform.position, Quaternion.identity);

            // Ignore Bullet <--> Player collisions
            Physics2D.IgnoreCollision(g.GetComponent<Collider2D>(),
                transform.parent.GetComponent<Collider2D>());
        }
		
	}
}
