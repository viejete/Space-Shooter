using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinuosVelocity : MonoBehaviour
{
    // The velocity
    public Vector2 velocity;

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
} 

