using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject targetObject;

    void Start()
    {

    }

    void Update()
    {
        Vector3 newPosition = transform.position - targetObject.transform.position;
        transform.position = newPosition;
        // transform.LookAt(targetObject.transform);
    }
}
