using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UIElements;

namespace Lecture17
{
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
        private Vector3 difference;
        public bool LookAt = true;
        public float cameraSpeed = 0.05f;

        void Start()
        {
            difference = transform.position - target.position;
            Debug.Log(difference);
        }

        void LateUpdate()
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, target.position + difference, cameraSpeed);
            transform.position = newPosition;
            if (LookAt)
            {
                transform.LookAt(target);
            }
        }
    }
}
