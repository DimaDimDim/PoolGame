using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunGoal : MonoBehaviour
{
    public GameObject Goal;
    //public GameObject cube;
    Vector3 newPosition;
    public Transform BALLL;

    Vector2 NEWBALLLPOS;


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player0")
        {
            other.transform.position = new Vector2(0, 0);
        }

        other.transform.position = Goal.transform.position; 
    }

}

