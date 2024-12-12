using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlayer : MonoBehaviour
{
    Vector3 previousPosition;
    Vector3 deltaPosition;

    float[] driver = new float[3] { 0, 0, 0 };

    [SerializeField]
    int index = 0;

    void Start()
    {
        previousPosition = transform.position;
        deltaPosition = Vector3.zero;
    }

    void Update()
    {
        deltaPosition = transform.position - previousPosition;
        previousPosition = transform.position;

        transform.Translate(deltaPosition, Space.World);
        transform.Translate(deltaPosition, Space.Self);

        AbelAlRaouf.AR(index, ref driver, deltaPosition.x);
    }
}
