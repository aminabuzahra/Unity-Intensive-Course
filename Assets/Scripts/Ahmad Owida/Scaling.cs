using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Scaling : MonoBehaviour
{

    float minScale = 0.05f;
    float maxScale = 5f;

    float scaleFactor = 1;


    void Start()
    {
        scaleFactor = minScale;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // Left
        {
            scaleFactor -= Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.D)) // Right
        {
            scaleFactor += Time.deltaTime;

        }
        scaleFactor = Mathf.Clamp(scaleFactor, minScale, maxScale);

        transform.localScale = Vector3.one * scaleFactor;
    }
}
