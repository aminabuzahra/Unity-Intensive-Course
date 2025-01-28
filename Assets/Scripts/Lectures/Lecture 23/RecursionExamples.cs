using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

namespace Lecture23
{
    public class RecursionExamples : MonoBehaviour
    {
        void Start()
        {
            // 5! = 5 * 4 * 3 * 2 * 1 = 120

            // n! = n * (n - 1) * (n -2) .... * (1)

            Debug.Log(RFactorial(5));
        }

        public int Factorial(int n)
        {
            int result = 1;
            for (int i = n; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }

        public int RFactorial(int n)
        {
            // Base Condition 
            if (n < 1) return 1;

            return n * RFactorial(n - 1); // recursion
        }

        public int Fibonacci(int n)
        {
            if (n < 0) return -1;

            // Base Condition
            if (n == 0) return 0;
            if (n == 1) return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
