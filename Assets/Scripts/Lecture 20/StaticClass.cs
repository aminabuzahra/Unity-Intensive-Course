using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture20
{
    public static class StaticClass
    {
        public static void enhancedPrint(string txt)
        {
            Debug.Log("E.." + txt);
        }

        // Extension Methods
        public static void resetPositionAndRotation(this Transform transform2, Vector3 pos, Quaternion rotation)
        {
            transform2.position = pos;
            transform2.rotation = rotation;
        }

        public static void printList<T>(this List<T> listOfHasans)
        {
            foreach (var num in listOfHasans)
            {
                Debug.Log(num);
            }
        }
    }
}

