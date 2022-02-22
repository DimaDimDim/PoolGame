using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRend : MonoBehaviour
{
    [SerializeField]
    //private GameObject linegeneratorprefab;
    LineRenderer linerend;
    Vector3 balpos;
    Vector3 mousepos1;
    Vector3 mousepos2;
    //Vector3 initpos;
    public Transform BALLL;

    private void Start()
    {

    }

    private void OnMouseDown()
    {
        //balpos = new Vector3(BALLL.position.x, BALLL.position.y, 0);
        mousepos1 = new Vector3(Input.mousePosition.x/50, Input.mousePosition.y/50, 0);
    }

    private void OnMouseDrag()
    {
        balpos = new Vector3(BALLL.position.x, BALLL.position.y, 0);
        mousepos2 = new Vector3(Input.mousePosition.x/50, Input.mousePosition.y/50, 0);
        //initpos = new Vector3(mousepos1 - mousepos2);
        SpawnLineGenerator();
        
    }

    private void SpawnLineGenerator()
    {
        linerend.SetPosition(0, balpos);
        linerend.SetPosition(1, (balpos + (mousepos1 - mousepos2)));
    }

    private void OnMouseUp()
    {
        linerend.SetPosition(0, new Vector3(0, 0, 0));
        linerend.SetPosition(1, new Vector3(0, 0, 0));
    }

}
