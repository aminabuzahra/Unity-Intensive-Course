using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture20
{
    public class MoveObject : MonoBehaviour
    {
        bool isReturnedBack = false;

        List<int> nums = new List<int> { 1, 2, 3, 4, 5 };

        void Start()
        {
            nums.printList();


        }

        void Update()
        {
            if (Time.time < 3)
            {
                transform.Translate(Vector3.right * Time.deltaTime);
                transform.Rotate(Vector3.up * Time.deltaTime * 20);
            }
            else if (Time.time > 5 && !isReturnedBack)
            {
                transform.resetPositionAndRotation(Vector3.zero, Quaternion.identity);
                isReturnedBack = true;
            }


        }
    }
}
