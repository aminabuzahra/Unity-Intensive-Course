using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TestingIfReachingDesiredPosition : MonoBehaviour
{
    public Transform targetObject;
    int direction = 1;

    void Start()
    {

        Debug.Log(targetObject.localScale.x);
    }

    void Update()
    {
        transform.position += new Vector3(direction * Time.deltaTime, 0, 0);
        if (Vector3.Distance(transform.position, targetObject.position) < (transform.localScale.x + targetObject.localScale.x) / 2f)
        {
            direction = -direction;
            Debug.Log("Object 1 reached Object 2");
        }
    }
}
