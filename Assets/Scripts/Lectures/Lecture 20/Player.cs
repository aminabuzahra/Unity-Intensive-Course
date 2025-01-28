using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Lecture20
{
    public class Player
    {
        public string Name { get; set; }

        string[] Amlak = new string[1_000_000];

        private int _health;
        public int Health
        {
            get { return _health; }
            set { _health = Mathf.Clamp(value, 0, 100); }
        }
        public Player(string name, int health)
        {
            this.Name = name;
            this.Health = health;
        }

        public Player(string name) : this(name, 100)
        {
        }

        public Player() : this("No Name", 100)
        {
        }

        ~Player()
        {
            Amlak = null;
        }

        public string getStatus()
        {
            // > 70 Bomb
            // 50 - 70 Good
            // 0 - 49 Al subhaniaeh

            // string status = Health > 70 ? "Bomb" : Health >= 50 ? "Good" : "Ala subhaniaeh";

            // if (Health >= 50)
            // {
            //     status = "Bomb";
            // }
            // else
            // {
            //     status = "Al subhaniaeh";
            // }

            return Health > 70 ? "Bomb" : Health >= 50 ? "Good" : "Ala subhaniaeh";
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
