using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Discussion_30_12
{
    public class ListSorting : MonoBehaviour
    {
        int[] numbers = new int[] { 12, 4, 24, 16, 38 };
        void Start()
        {
            numbers = Sort();
            foreach (var num in numbers)
                print(num);
        }

        int[] Sort()
        {
            int[] result = numbers;
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] > result[i + 1])
                {
                    int temp = result[i];
                    result[i] = result[i + 1];
                    result[i + 1] = temp;
                }
            }
            return result;
        }
    }
}
