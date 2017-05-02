﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name != "PlayerShip")
        {
            Destroy(coll.gameObject);
        }
    }
}
