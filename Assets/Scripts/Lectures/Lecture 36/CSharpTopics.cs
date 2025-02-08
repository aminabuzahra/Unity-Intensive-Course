using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture36
{
    public class CSharpTopics : MonoBehaviour
    {
        int? c;
        char l;
        string name;
        // Value types int, float, double, .....

        Sameer sameer; // null
        int? a; // equivelant to Nullable<int> a;
        // int? scoreFromDB;
        Nullable<int> scoreFromDB;

        void Start()
        {
            Debug.Log(c);
            l = 'a';
            Debug.Log(l);
            Debug.Log(sizeof(int));
            Debug.Log(sizeof(float));
            Debug.Log(sizeof(double));
            Debug.Log(sizeof(char));

            sameer = null;
            Debug.Log(sameer);
            // sameer.doSomething();

            scoreFromDB = null;

            if (scoreFromDB.HasValue)
            {
                Debug.Log(scoreFromDB.Value);
            }

            Debug.Log(scoreFromDB);

            a = scoreFromDB ?? -1;

            Debug.Log(a);
        }

    }

    public class Sameer
    {
        public void doSomething()
        {
        }
    }
}