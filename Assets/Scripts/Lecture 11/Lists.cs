using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture11
{
    public class Lists : MonoBehaviour
    {
        int[] arr = { 1, 2, 3 };

        List<int> list1 = new List<int>();

        List<int> list2 = new List<int> { 1, 2, 3, 4 };

        List<object> list3 = new List<object> { "Subhi", 1.5f, 5, true };

        List<string> list4 = new List<string>();

        void Start()
        {

            list1.AddRange(arr);  // From Array to List

            int[] fromList = list2.ToArray(); // From List to Array

            arr[1] = 5;
            arr[2] = 6;

            for (int i = 0; i < arr.Length; i++)
            {
                Debug.Log(arr[i]);
            }

            list2.Add(3);
            list4.Add("Raed");

            for (int i = 0; i < list2.Count; i++)
            {
                Debug.Log(list2[i]);
            }

            foreach (int n in list2) // {1,2,3,4}
            {
                Debug.Log(n);
            }

            foreach (int n in arr) // {1,2,3,4}
            {
                Debug.Log(n);
            }

            foreach (object n in list3) // {1,2,3,4}
            {
                Debug.Log(n);
            }
        }
    }
}