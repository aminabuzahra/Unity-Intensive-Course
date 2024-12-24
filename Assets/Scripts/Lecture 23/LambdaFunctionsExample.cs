using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture23
{
    public class LambdaFunctionsExample : MonoBehaviour
    {
        List<int> numbers = new List<int> { 1, 2, 4, 5, 6, 8, 5 };
        void Start()
        {
            foreach (var i in numbers.FindAll((int i) => i > 5))
            {
                Debug.Log(i);
            }

            Action action = () => Debug.Log("Subhi");
            action();

            Func<int, int, int> func = (int a, int b) => a + b;

            Predicate<int> isPositive = (int a) => a >= 0;

            numbers.Find((int i) => i == 5);
        }
    }
}
