using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture13
{
    public class InputLesson : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Debug.Log(Mathf.PI);
            // Debug.Log(Mathf.Exp(1));
            // Debug.Log(Mathf.Abs(-10));
            // Debug.Log(Mathf.Min(1, 2, 3, 4, 5));
            // Debug.Log(Mathf.Max(1, 2, 3, 4, 5));

            // Debug.Log(Mathf.Clamp(101, 0, 100));
            // Debug.Log(Mathf.Clamp(-1, 0, 100));
            // Debug.Log(Mathf.Clamp(5, 0, 100));

            // Debug.Log(Mathf.Round(1.6f));
            // Debug.Log(Mathf.Round(1.2f));

            // Debug.Log(Mathf.Lerp(0f, 10f, 0.5f));

            // Debug.Log(Mathf.Sin(0));
            // Debug.Log(Mathf.Cos(0));
            // Debug.Log(Mathf.Tan(0));

            // Debug.Log(Mathf.Sqrt(25));
            // Debug.Log(Mathf.Pow(5,2));
            // health = Math.Clamp(value, 0, 100);

            // Debug.Log(Mathf.PingPong());  // Saja Time, Transform
        }

        void Update()
        {
            // if (Input.GetMouseButtonUp(0))  // Left Button
            // {
            //     Debug.Log("Mouse Left Button");
            // }

            // if (Input.GetMouseButtonUp(1))  // Right Button
            // {
            //     Debug.Log("Mouse Middle Button");
            // }

            // if (Input.GetMouseButtonUp(2))  // Middle Button
            // {
            //     Debug.Log("Mouse Right Button");
            // }

            // if (Input.mouseScrollDelta.y != 0) // Mouse Wheel Scrolling
            // {
            //     Debug.Log("Mouse Scrolling Occured : " + Input.mouseScrollDelta.y);
            // }

            // Vector3 v1 = new Vector3(1, 1, 0);  // Immutable Values غير قابلة للتعديل
            // Vector3 v2 = new Vector3(1, 0, 0);
            // Vector3 v3 = v1 + v2; // (2,1,0)
            // Vector3 v4 = v1 * 5; // (5,5,0)
            // Vector3 v5 = 5 * v1; // (5,5,0)

            // Vector3 beginVector = new Vector3(0, 0, 0);
            // Vector3 endVector = new Vector3(1, 0, 0);

            // Debug.Log(Vector3.Lerp(beginVector, v4, 0.5f));

            // Time Class
            // Debug.Log(Time.time);
            // Debug.Log(Time.frameCount);
            // Debug.Log(Time.deltaTime); // لها شأن عظيم // Doaa
            // Debug.Log(Time.fixedDeltaTime); 
            // Time.timeScale = 0f; // Default value 1; // Physics Engine // Mohammad
            // Debug.Log(Time.unscaledTime);
        }
    }
}