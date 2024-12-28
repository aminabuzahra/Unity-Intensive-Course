using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture24
{
    public class ChainMehtodsExamples : MonoBehaviour
    {
        class MathAlhasan
        {
            int _value;

            public int Value
            {
                get => _value;

                private set => _value = value;
            }

            public MathAlhasan(int v) => this.Value = v;

            public MathAlhasan Add(int v)
            {
                Value += v;
                return this;
            }
            public MathAlhasan Subtract(int v)
            {
                Value -= v;
                return this;
            }

            public MathAlhasan Multiply(int v)
            {
                Value *= v;
                return this;
            }

            public MathAlhasan Divide(int v)
            {
                Value = v != 0 ? Value / v : Value;
                return this;
            }

            public MathAlhasan Build()
            {
                return this;
            }

            // public void Divide2(int v)
            // {
            //     if (v != 0) Value = Value / v;
            //     else
            //         Value = Value;
            // }

            // public float Divide3(int v) => v != 0 ? Value / v : Value;

        }

        void Start()
        {
            MathAlhasan ma = new MathAlhasan(7);

            ma.Add(1).Divide(2).Multiply(5).Subtract(3);

            // ma.Add(1);
            // ma.Divide(2);
            // ma.Multiply(5);
            // ma.Subtract(3);

            Debug.Log(ma.Value);
        }
    }
}


