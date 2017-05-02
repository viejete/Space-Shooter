using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject ship;

    // the interval
    public float interval = 1;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext()
    {
        Instantiate(ship, transform.position, Quaternion.identity);
    }
}
