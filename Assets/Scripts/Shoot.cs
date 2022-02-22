using UnityEngine;
using System.Collections;
using System;

public class Shoot : MonoBehaviour
{

    public Transform BALLL;
    Vector3 initPos;
    Vector3 SecondPos;
    //get the initial positon of the holder before the drag starts
    void OnMouseDown()
    {
        initPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
    }

    //move the holder according to the drag
    void OnMouseDrag()
    {
        SecondPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
    }

    //add force to the disc in the direction of the line between
    //the current position of the holder and its initial position
    void OnMouseUp()
    {
        BALLL.GetComponent<Rigidbody2D>().AddForce(((initPos-SecondPos)) * Vector3.Distance(transform.position, initPos)*50);
    }
}
