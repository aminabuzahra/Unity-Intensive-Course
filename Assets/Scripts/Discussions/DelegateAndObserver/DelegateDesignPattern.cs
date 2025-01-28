using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DelegateAndObserverDesignPatterns
{
    public enum HealthAction
    {
        Increase,
        Decrease
    }

    public delegate void DelegateType(int paramater1, HealthAction healthAction);

    public class DelegateDesignPattern : MonoBehaviour
    {
        public static event DelegateType delegateHealth;

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                delegateHealth?.Invoke(10, HealthAction.Decrease);
            }

            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                delegateHealth?.Invoke(10, HealthAction.Increase);
            }
        }
    }
}
