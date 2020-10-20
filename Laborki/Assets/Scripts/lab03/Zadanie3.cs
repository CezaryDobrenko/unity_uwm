using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3 : MonoBehaviour
{

    public float speed;
    public Vector3[] points;
    private int nextPointIndex = 0;

    void Start()
    {
        
    }

    void Update()
    {
        //K.I.S.S ¯\_(ツ)_/¯

        if ((Vector3)transform.position == points[nextPointIndex])
        {
            nextPointIndex = (nextPointIndex + 1) % points.Length;
            transform.Rotate(0,90,0);
        }

        transform.position = Vector3.MoveTowards(transform.position, points[nextPointIndex], speed * Time.deltaTime);
    }
}
