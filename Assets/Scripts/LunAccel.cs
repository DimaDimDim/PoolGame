using UnityEngine;
using System.Collections;
using System;

public class LunAccel : MonoBehaviour
{
    Vector2 AAA = Vector2.left;
    Vector2 BBB = Vector2.right;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.position.x < 1)
        {
            other.GetComponent<Rigidbody2D>().AddForce(AAA * 50);
        }
        else
        {
            other.GetComponent<Rigidbody2D>().AddForce(BBB * 50);
        }
    }
}

