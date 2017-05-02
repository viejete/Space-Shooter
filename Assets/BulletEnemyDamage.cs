using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyDamage : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Collided with a Ship? Then destroy it
        if (coll.gameObject.tag == "ship")
        {
            Destroy(coll.gameObject);
        }

        // Destroy the bullet in any case
        Destroy(gameObject);
    }
}
