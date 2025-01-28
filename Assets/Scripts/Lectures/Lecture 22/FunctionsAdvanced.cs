using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture22
{
    public class FunctionsAdvanced : MonoBehaviour
    {
        void Start()
        {
            printSomething();
            print(addNumbers(1, 2));
            print(doubleNumber(2));
            printNumber(5);
        }

        void printSomething() => Debug.Log("Printed Something");

        int addNumbers(int a, int b) => a + b;

        int doubleNumber(int a) => a * 2;

        void printNumber(int a) => Debug.Log(a);
    }
}