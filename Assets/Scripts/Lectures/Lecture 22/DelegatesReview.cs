using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture22
{
    public delegate void DelegateExample();
    public delegate int ArithmaticDelegate(int a, int b);
    public class DelegatesReview : MonoBehaviour
    {
        // DelegateExample functionVariable;
        // int number;

        ArithmaticDelegate arithmaticDelegate;

        void Start()
        {
            // number = 10;
            // functionVariable = DoSomething;
            // functionVariable();
            // ExecuteAnotherMethod(DoSomething);

            // arithmaticDelegate = ;

            Debug.Log(doArithmatic(addNumbers, 1, 2));
            Debug.Log(doArithmatic(multiplyNumbers, 1, 2)); // Functional Programming
        }

        void ExecuteAnotherMethod(DelegateExample methodParameter)
        {
            methodParameter();
        }

        int doArithmatic(ArithmaticDelegate doSoemthingOnNumbers, int n1, int n2)
        {
            return doSoemthingOnNumbers(n1, n2);
        }

        public void DoSomething()
        {
            Debug.Log("I did something");
        }

        public int addNumbers(int n1, int n2)
        {
            return n1 + n2;
        }

        public int multiplyNumbers(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
