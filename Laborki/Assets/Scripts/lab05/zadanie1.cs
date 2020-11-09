using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie1 : MonoBehaviour
{
    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    public float distance = 6.6f;
    private bool isAway = false;
    private float backward;
    private float forward;

    void Start()
    {
        forward = transform.position.z + distance;
        backward = transform.position.z;
    }

    void Update()
    {
        if (transform.position.z >= forward && isAway == false)
        {
            isAway = true;
            elevatorSpeed = -elevatorSpeed;
        }
        if (transform.position.z < backward && isAway == true)
        {
            isRunning = false;
            isAway = false;
            elevatorSpeed = -elevatorSpeed;
        }
        if (isRunning)
        {
            Vector3 move = transform.forward * elevatorSpeed * Time.deltaTime;
            transform.Translate(move);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszedł z windy.");
        }
    }

}