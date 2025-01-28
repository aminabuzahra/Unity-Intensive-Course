using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassScope : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class MS
{
    private int v;

    private class Falak
    {
        MS data;
        private Falak(MS mS)
        {
            data = mS;
        }
        void DoSomething()
        {
            int a = data.v;
        }

    }
}
