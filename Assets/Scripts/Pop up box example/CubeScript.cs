using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    float scaleSensitivity = 50;

    float angleSensitivity = 500;
    float cubeScaleFactor = 0f;

    float cubeAngle = 0;


    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            cubeScaleFactor += Input.GetAxis("Mouse X") * scaleSensitivity * Time.deltaTime;
            cubeScaleFactor = Mathf.Clamp(cubeScaleFactor, 0, 3);
            transform.localScale = new Vector3(cubeScaleFactor / 2, cubeScaleFactor, cubeScaleFactor / 2);

            cubeAngle += Input.GetAxis("Mouse X") * angleSensitivity * Time.deltaTime;
            cubeAngle = Mathf.Clamp(cubeAngle, 0, 90);

         
            transform.rotation = Quaternion.Euler(0, cubeAngle, 0);
        }
    }
}
