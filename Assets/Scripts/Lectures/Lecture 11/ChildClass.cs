using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture11
{
    public class ChildClass : BaseClass
    {
        public override void printInfo()
        {
            // base.printInfo();
            Debug.Log("I am the poor Sabi !!");
        }
    }
}

namespace Lecture11_5
{
    using Lecture11;
    public class ChildClass
    {
        Lecture11.ChildClass cc = new Lecture11.ChildClass();
        public void printInfo2()
        {
            // base.printInfo();
            Debug.Log("I am the poor Sabi from the next Neigbnorhood!!");
        }

        public void printCC()
        {
            cc.printInfo();
        }
    }
}
