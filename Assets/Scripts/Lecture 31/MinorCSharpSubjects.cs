using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using static UnityEngine.Debug;
using static UnityEngine.Vector3;

namespace Lecture31
{
    public class MinorCSharpSubjects : MonoBehaviour
    {
        enum Rozan
        {
            studying,
            reading,
            programming
        }

        Rozan rozan = Rozan.studying;

        int Maqloubeh = 100;

        void Start()
        {
            Log($"The variable {nameof(MinorCSharpSubjects)} has {Maqloubeh} value.");
            Log(rozan);
            Log(nameof(Vector3.up));



            // Log("Subhi");
            // Debug.Log("Sameer");
            // Log("Abu Alaa");
            // Vector3 v = up;

            AlHasan alhoson = new AlHasan();
            AlHasan alhoson2 = new AlHasan();

            alhoson.GetType();

            Log(typeof(AlHasan));
            Log(alhoson.GetType());

            Type type = typeof(AlHasan);



            MethodInfo[] methodInfos = type.GetMethods();
            foreach (var method in methodInfos)
            {
                Log(method.Name);
            }

        }

        class AlHasan
        {
            public int a
            {
                get; set;

            }
            public void doSomething()
            { }
        }
    }
}