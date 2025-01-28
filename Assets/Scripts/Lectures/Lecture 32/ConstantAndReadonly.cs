using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture32
{
    public class ConstantAndReadonly : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Constants.a);
            Constants constants = new(10);
            Debug.Log(constants.b);
            constants.c.Add(5);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    public class Constants
    {
        public const int a = 10; // static field
        public readonly int b; // non-static field

        public int d
        {
            get;
        }

        public readonly List<int> c = new List<int>();

        // static Constants()
        // {
        //     b = 10;
        // }
        public Constants(int num)
        {
            // b = num;
        }
    }
}