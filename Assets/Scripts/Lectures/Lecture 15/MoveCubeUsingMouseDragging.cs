using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture15
{
    public class MoveCubeUsingMouseDragging : MonoBehaviour
    {
        float speed = 5f;

        void Start()
        {
            Camera.main.backgroundColor = Color.red;
        }

        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = 10;

                // float Z = transform.position.z;
                Vector3 InUnityPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                // InUnityPosition.z = Z;
                // transform.position = InUnityPosition;
                transform.position = Vector3.Lerp(transform.position, InUnityPosition, speed * Time.deltaTime);
            }
        }
    }
}
