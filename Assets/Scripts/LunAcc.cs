using UnityEngine;
using System.Collections;
using System;

public class LunAcc : MonoBehaviour
{
    Vector2 UpL = new Vector2(-1,1);
    Vector2 UpR = new Vector2(1,1);
    Vector2 DoL = new Vector2(-1, -1);
    Vector2 DoR = new Vector2(1, -1);

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform.position.x < 0 && other.transform.position.y > 0)
        {
            other.GetComponent<Rigidbody2D>().AddForce(UpL * 50);
        }
        if (other.transform.position.x > 0 && other.transform.position.y > 0)
        {
            other.GetComponent<Rigidbody2D>().AddForce(UpR * 50);
        }
        if (other.transform.position.x < 0 && other.transform.position.y < 0)
        {
            other.GetComponent<Rigidbody2D>().AddForce(DoL * 50);
        }
        if (other.transform.position.x > 0 && other.transform.position.y < 0)
        {
            other.GetComponent<Rigidbody2D>().AddForce(DoR * 50);
        }
    }
}

