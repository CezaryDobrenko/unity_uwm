using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie4 : MonoBehaviour
{
    public float speed = 2.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Obstacle")
        {
            Debug.Log("Wszedłem w kolizję z przeszkodą!");
        }
    }

    void FixedUpdate()
    {
        float mH = Input.GetAxis("Horizontal");
        float mV = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(mH, 0, mV);
        velocity = velocity.normalized * speed * Time.deltaTime;

        rb.MovePosition(transform.position + velocity);
    }
}
