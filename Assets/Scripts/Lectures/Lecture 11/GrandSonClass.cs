using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture11
{
    public class GrandSonClass : ChildClass
    {
        public override void printInfo()
        {
            base.printInfo();
            
            Debug.Log("I am the Musakham !!");
        }

    }
}
