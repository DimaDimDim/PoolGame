using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunGoal2 : MonoBehaviour
{
    public GameObject Goal;
    void OnTriggerExit2D(Collider2D other)
    {
        other.transform.position = Goal.transform.position;
    }
}
