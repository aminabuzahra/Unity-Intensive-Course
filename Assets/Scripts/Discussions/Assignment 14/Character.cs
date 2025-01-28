using UnityEngine;

namespace Assignment14
{
    public class Character
    {

        private int _health = 0;

        public string Name
        {
            get;
            set;
        }

        public int Health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = Mathf.Clamp(value, 0, 100);
                // _health = value;
                // if (_health > 100)
                // {
                //     _health = 100;
                // }
                // else if (_health < 100)
                // {
                //     _health = 0;
                // }
            }
        }

        public Character(string characterName, int characterHealth)
        {
            Name = characterName;
            Health = characterHealth;
        }
    }
}
