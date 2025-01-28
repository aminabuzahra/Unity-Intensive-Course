using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture18
{
    public class TestInterfaceExample : MonoBehaviour
    {
        void Start()
        {
            ImplementingInterfaceExample bie = new ImplementingInterfaceExample();
            bie.DoComplicatedThing();
        }
    }
}
