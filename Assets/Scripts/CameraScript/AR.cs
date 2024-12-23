using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AR : MonoBehaviour
{
    float xAxis;
    float yAxis;

    void Update()
    {
        Vector3 newPosition = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * 3f, 0, Input.GetAxis("Vertical") * Time.deltaTime * 3f);
        transform.position += newPosition;

        xAxis += Input.GetAxis("Mouse X");
        yAxis -= Input.GetAxis("Mouse Y");
        transform.rotation = Quaternion.Euler(yAxis, xAxis, 0);
    }
}
