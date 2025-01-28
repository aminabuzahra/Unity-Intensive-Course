using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture24
{
    public class AbstratClassExample : MonoBehaviour
    {
        void Start()
        {
        }

        void Update()
        {
        }
    }

    public abstract class Subhi
    {
        public void Walk()
        {
            Debug.Log("Walk!");
        }

        public abstract void Cook();
    }

    public abstract class Affash
    {
        public void SubCoffee()
        {
            Debug.Log("Coffe!");
        }

        public abstract void UseSword();
    }

    public class SonOfSubhi : Subhi
    {
        public override void Cook()
        {
            Debug.Log("I can cook!");
        }
    }
}
