using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture10
{
    public class Kitten : Cat
    {
        public Kitten() : base("")
        {

        }
        public override void MakeSound()
        {
            Debug.Log("meo");
        }
    }
}
