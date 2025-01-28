using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syncrozination : MonoBehaviour
{
    float cubeAngle = 0;
    float mouseMovement = 0;

    float x, y, z = 0f;

    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mouseMovement += Input.GetAxis("Mouse X") * Time.deltaTime * 12f;
            mouseMovement = Mathf.Clamp(mouseMovement, 0.0f, 1.0f);

            // Scaling
            x = Mathf.Lerp(0, 3, mouseMovement);
            y = Mathf.Lerp(0, 3, mouseMovement);
            z = Mathf.Lerp(0, 3, mouseMovement);
            transform.localScale = new Vector3(x / 2, y, z / 2);

            // Rotation
            cubeAngle = Mathf.Lerp(0, 90, mouseMovement);
            transform.rotation = Quaternion.Euler(0, cubeAngle, 0);
        }
    }
}
