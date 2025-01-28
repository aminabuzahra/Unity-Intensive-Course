using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    public float rotationalSpeed = 100; // Degrees in secons



    void Update()
    {
        // transform.Rotate(Vector3.down, rotationalSpeed * Time.deltaTime, Space.Self); // Local -- By Default
        transform.Rotate(Vector3.down, rotationalSpeed * Time.deltaTime, Space.World); // Global
    }
}
