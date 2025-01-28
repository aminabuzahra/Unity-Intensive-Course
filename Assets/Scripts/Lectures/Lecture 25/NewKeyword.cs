using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture25
{
    public class NewKeyword : MonoBehaviour
    {
        void Start()
        {
            // Animal[] animals = new Animal[] { new Cat(), new Subhi() };
            // foreach (var anim in animals)
            //     anim.MakeSound();

            Animal animal = new Cat();
            animal.MakeSound(); // Polymorphoism   // Meow
            animal.Move();      // Method hiding   // Animal moves
            // ((Cat)animal).Move();
            (animal as Cat)?.Move(); // *** Prefered version
        }
    }

    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }

        public void Move()
        {
            Debug.Log("Animal moves.");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Meow");
        }

        public new void Move()
        {
            Debug.Log("Cat moves.");
        }
    }

    public class Subhi : Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Bijaeer");
        }

        public new void Move()
        {
            Debug.Log("Animal moves.");
        }
    }
}

