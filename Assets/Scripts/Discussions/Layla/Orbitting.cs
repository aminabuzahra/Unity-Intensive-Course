using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitting : MonoBehaviour
{
    public float rotationalSpeed = 100;
    public Transform sun;

    void Update()
    {
        transform.RotateAround(sun.position, Vector3.down, rotationalSpeed * Time.deltaTime);
    }
}
