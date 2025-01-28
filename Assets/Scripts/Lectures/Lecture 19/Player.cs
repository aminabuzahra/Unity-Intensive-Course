using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture19
{
    public class Player : MonoBehaviour
    {
        int _health = 100;
        float executeTime = 1;
        bool isDead = false;

        int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = Mathf.Clamp(value, 0, 100);
            }
        }

        public GameStages onHealthLoosed;

        void Update()
        {
            if ((Time.time > executeTime) && !isDead)
            {
                TakeDamage(500);
                isDead = true;
            }
        }

        void TakeDamage(int amountOfDamage)
        {
            Health -= amountOfDamage;
            if (Health == 0)
            {
                if (onHealthLoosed != null)
                {
                    onHealthLoosed.Invoke();
                }
                // onHealthLoosed?.Invoke();
            }
        }
    }
}
