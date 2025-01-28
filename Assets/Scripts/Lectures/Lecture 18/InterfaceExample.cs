using System;
using UnityEngine;

// Architect / Engineer ******* blueprints - Interfaces
// Senior Developer ***
// Junior Developer --
// Sabi Junior -

namespace Lecture18
{
    public class Player
    {
        public void dash()
        {
            Debug.Log("Dash");
        }
    }
    public interface IInterfaceExample
    {
        public int Health
        {
            get;
            set;
        }

        public void DoComplicatedThing();
    }

    public interface IHavingSound
    {
        public void makeSound();
    }

    public interface ICanMove
    {
        public void move();
    }

    public interface ICanJump
    {
        public void jump();
    }

    public class ImplementingInterfaceExample : IInterfaceExample
    {
        private int _health = 100;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = Math.Clamp(value, 0, 100);
            }
        }

        public void DoComplicatedThing()
        {
            Debug.Log("Subhi");
        }
    }

    public class Ori : Player, ICanMove, ICanJump
    {
        public void move()
        {
            Debug.Log("Moved Habibi");

        }
        public void jump()
        {
            Debug.Log("Jumped Habibi");
        }

        public new void dash()
        {
            Debug.Log("Improved Dash");
        }
    }

}
