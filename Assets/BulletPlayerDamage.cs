using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayerDamage : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        // Collided with a Ship? Then destroy it
        if (coll.gameObject.tag == "EnemyShip")
        {
            Destroy(coll.gameObject);
        }

        // Destroy the bullet in any case
        Destroy(gameObject);
    }
}
