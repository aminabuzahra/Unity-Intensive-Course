using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture19
{

    public interface IHuman
    {
    }

    public interface IAnimal
    {
    }

    public interface IWalkable
    {
        public void Walk();
    }

    public interface ISwimmable
    {
        public void Swim();
    }

    public class Student : IHuman, IWalkable, ISwimmable
    {
        public void Walk()
        {
            Debug.Log("Student Walk");
        }

        public void Swim()
        {
            Debug.Log("Swim");
        }
    }

    public class Robot : IWalkable
    {
        public void Walk()
        {
            Debug.Log("Robot Walk");
        }
    }

    public class Fish : IAnimal, ISwimmable
    {
        public void Swim()
        {
            Debug.Log("Swim");
        }
    }

    public class Gorilla : IAnimal, IWalkable
    {
        public void Walk()
        {
            Debug.Log("Gorilla Walk");
        }
    }

    public class InterfacesReview : MonoBehaviour
    {
        ISwimmable[] swimmables;
        IWalkable[] walkables;

        List<int> numbers = new List<int>();

        void Start()
        {
            swimmables = new ISwimmable[] { new Student(), new Fish() };
            walkables = new IWalkable[] { new Student(), new Gorilla(), new Robot() };

            // foreach (ISwimmable swimmable in swimmables)
            // {
            //     swimmable.Swim();
            // }

            // foreach (IWalkable walkable in walkables)
            // {
            //     walkable.Walk();
            // }

            IEnumerator a = getValue();
            while (a.MoveNext())
            {
                Debug.Log(a.Current);
            }

            // while (a.MoveNext())
            // {
            //     Debug.Log(a.Current);
            //     break;
            // }

        }

        IEnumerator getValue()
        {
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 9;
            yield return 2;
            yield return 6;
        }
    }
}
