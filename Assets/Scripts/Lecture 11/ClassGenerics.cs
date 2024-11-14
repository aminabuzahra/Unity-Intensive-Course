using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture11
{
    public class ClassGenerics<T>
    {
        public T v;

        public ClassGenerics(T val)
        {
            this.v = val;
        }

        public void printV()
        {
            Debug.Log(v);
        }
    }
}
