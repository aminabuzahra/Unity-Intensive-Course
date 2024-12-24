using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using Unity.VisualScripting;

namespace Lecture23
{

    // [Serializable]
    // public class OurUnityEvent : UnityEvent<int, string> { }

    public class UnityEventExample : MonoBehaviour
    {
        [SerializeField]
        private int a = 5;
        public int b = 10;

        public UnityEvent<int, string> unityEvent;

        void OnEnable()
        {
            unityEvent.AddListener(WasfiyehListener.EventListner);
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                unityEvent?.Invoke(1, "Raed");
            }
        }

        public void doXYZ(int i, string name)
        {
            Debug.Log("Mlukhieh");
        }
    }
}
