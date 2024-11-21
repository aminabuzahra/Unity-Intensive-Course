using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDeltaTime : MonoBehaviour
{
    public float speed = 1; // m / s

    void Start()
    {
        Debug.Log(float.MaxValue);

    }

    void Update()

    {
        // deltaTime
        transform.position += new Vector3(1 * Time.deltaTime, 0, 0);     // 0.0025     * 400 = 1
                                                                         // 0.00125    * 800 = 1
                                                                         // 0.02       * 50 = 1
    }
}
