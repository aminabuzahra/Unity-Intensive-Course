using System;
using System.Collections;
using System.Collections.Generic;
// using DelegateAndObserverDesignPatterns;
using UnityEditorInternal;
using UnityEngine;

namespace DelegateAndObserverDesignPatterns
{
    public class HealthSystem : MonoBehaviour
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
                _health = Mathf.Clamp(value, 0, 100);
            }
        }

        void OnEnable()
        {
            DelegateDesignPattern.delegateHealth += changeHealth;
            DelegateDesignPattern.delegateHealth += printNewHealth;
        }

        void Update()
        {
        }

        public void changeHealth(int amount, HealthAction healthAction)
        {
            switch (healthAction)
            {
                case HealthAction.Increase:
                    Health += amount;
                    break;

                case HealthAction.Decrease:
                    Health -= amount;
                    break;
            }
        }

        public void printNewHealth(int amount, HealthAction healthAction)
        {
            Debug.Log($"Health now is: {Health}");
        }

        void OnDisable()
        {
            DelegateDesignPattern.delegateHealth -= changeHealth;
            DelegateDesignPattern.delegateHealth -= printNewHealth;
        }
    }
}
