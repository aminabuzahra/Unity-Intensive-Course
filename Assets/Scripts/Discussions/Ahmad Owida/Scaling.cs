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
        // transform.GetChild(0).gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // Left
        {
            // transform.GetChild(0).gameObject.SetActive(true);
            scaleFactor -= Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.D)) // Right
        {
            // transform.GetChild(0).gameObject.SetActive(true);
            scaleFactor += Time.deltaTime;
        }
        scaleFactor = Mathf.Clamp(scaleFactor, minScale, maxScale);

        transform.localScale = Vector3.one * scaleFactor;
    }
}
