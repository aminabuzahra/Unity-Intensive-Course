using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture23
{

    public delegate void DelegateExample();
    public class ActionExample : MonoBehaviour
    {

        public static  DelegateExample functionM;

        void OnEnable()
        {
            // functionM = doSomething; // not recommended

            functionM += doSomething;
            functionM += doSomething;
        }
        void Start()
        {
            // functionM();
            // functionM.Invoke();
            functionM?.Invoke();
        }

        public void doSomething()
        {
            Debug.Log("Subhi");
        }

        void OnDisable()
        {
            functionM -= doSomething;
            functionM -= doSomething;
        }

    }



}


