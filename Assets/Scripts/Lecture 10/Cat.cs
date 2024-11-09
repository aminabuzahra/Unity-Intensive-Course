using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture10
{
    public class Cat : Animal
    {
        public Cat(string catName) : base(catName)
        {

        }
        public override void MakeSound()
        {
            Debug.Log("Meooooow");
        }

        public void SetName(string animalName)
        {
            name = animalName;
        }
    }
}
