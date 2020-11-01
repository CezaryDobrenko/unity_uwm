using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie4 : MonoBehaviour
{
    public Transform player;

    public float sensitivity = 200f;
    float horizontalRotation = 0;
    float verticalRotation = 0;

    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        horizontalRotation += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        verticalRotation -= Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);
        player.transform.localRotation = Quaternion.Euler(verticalRotation, horizontalRotation, 0);


    }
}
