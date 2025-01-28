using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture11
{
    public class TestClasses : MonoBehaviour
    {
        void Start()
        {
           BaseClass boss = new BaseClass();
           ChildClass sabi = new ChildClass();
           GrandSonClass m = new GrandSonClass();
        //    boss.printInfo();
        //    sabi.printInfo();
           m.printInfo();
        }
    }
}
