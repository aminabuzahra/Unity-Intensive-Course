using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture24
{
    public class BoxingVSUpcasting : MonoBehaviour
    {
        
        // generics vs object
        // Boxing/Unboxing vs Upcasting/Downcasting

        void Start()
        {
            printValues(new int[] { 1, 2, 3, 4, 5 });
            printValues2(new object[] { 1, 2, 3, 4, 5 });

        }

        public void printValues<T>(T[] listOfValues)
        {
            foreach (T item in listOfValues)
                Debug.Log(item);
        }

        public void printValues2(object[] objects)
        {
            foreach (object item in objects)
                Debug.Log(item);
        }
    }
}

