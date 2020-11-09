using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zaadanie3 : MonoBehaviour
{

    public float speed;
    public Vector3[] points;
    private int nextPointIndex = 0;
    bool direction = true;
    int test = 1;

    void Update()
    {
        //Make america great again (404 trump not found)

        if ((Vector3)transform.position == points[nextPointIndex])
        {
            nextPointIndex = (nextPointIndex + test);
            //Reverse direction of platform if index 0 or index pionts.length
            if (nextPointIndex == points.Length-1 || nextPointIndex == 0)
                test = test * -1;
        }

        transform.position = Vector3.MoveTowards(transform.position, points[nextPointIndex], speed * Time.deltaTime);
    }
}
