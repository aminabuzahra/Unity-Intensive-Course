using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture11
{
    public struct OperatorOverloading
    {
        public int v;

        public OperatorOverloading(int v)
        {
            this.v = v;
        }

        public static int operator +(OperatorOverloading a, OperatorOverloading b)
        {
            return a.v + b.v;
        }
        public static int operator +(OperatorOverloading a, int b)
        {
            return a.v + b;
        }
        public static int operator *(int b, OperatorOverloading a)
        {
            return a.v * b;
        }
    }
}
