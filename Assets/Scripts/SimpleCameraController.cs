using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System;

public class SimpleCameraController : MonoBehaviour
{
    // Control the direction of the camera
    Vector2 rotation = new Vector2(0, 0);

    // Adjust the speed the direction rotation
    public float speed = 3;

    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x += -Input.GetAxis("Mouse Y");
        transform.eulerAngles = (Vector2)rotation * speed;
    }
}
