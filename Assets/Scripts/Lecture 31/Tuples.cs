using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Tuples : MonoBehaviour
{
    (int, bool, string) tuple;

    void Start()
    {
        tuple = (1, true, "Subhi");

        var t2 = (name: 1, alive: true);

        // Debug.Log(tuple);

        Debug.Log(t2.name);
        Debug.Log(t2.alive);

        t2.name = 7;
        Debug.Log(t2.name);


        // tuple = (5, false, "Khader");
        // Debug.Log(tuple);

        int a;
        bool b;
        string c;

        // Destructing
        (a, b, c) = tuple;
        // Debug.Log(a);
        // Debug.Log(b);
        // Debug.Log(c);

        int v1 = 10;
        int v2 = 20;

        (v1, v2) = (v2, v1);
    }

    void Update()
    {

    }
}
