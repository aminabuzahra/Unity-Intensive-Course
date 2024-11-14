using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture11
{
    public class MethodGenerics
    {
        public static void PrintNumber<T>(T a)
        {
            Debug.Log(a);
        }
    }
}
