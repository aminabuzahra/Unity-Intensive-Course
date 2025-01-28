using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture10
{
    public class MethodOverriding : MonoBehaviour
    {
        Animal animal;
        Cat cat;
        Kitten kitten;

        Player player = new Player();

        Animal[] animalFarm = new Animal[3];
        Data[] students = new Data[5000];

        void Start()
        {
            Debug.Log(player.health1);
            animal = new Animal("Ghazal");
            cat = new Cat("Misho");
            kitten = new Kitten();

            animalFarm[0] = animal;
            animalFarm[1] = cat;
            animalFarm[2] = kitten;

            // animal.MakeSound();
            // cat.MakeSound();
            // kitten.MakeSound();

            for (int i = 0; i < animalFarm.Length; i++)  // 2
            {
                // Animal animal = animalFarm[i];
                // animal.MakeSound();

                animalFarm[i].MakeSound();
            }



            Debug.Log(cat.name);

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Data("Subhi", 100);
            }

            // animal.name = "Sinjab";
        }
    }
}