using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class Explanation : MonoBehaviour
{
    public class Subhi
    {
        public void DoSomething()
        {
            Debug.Log("I Did something");
        }
    }

    Subhi subhi;

    void Start()
    {
        subhi = new Subhi();
    }

    public void ExecuteFunction(Subhi s)
    {
        s.DoSomething();
    }
}
