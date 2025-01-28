using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture32 // by: Raed Abu Dayyeh
{
    public class TuplesReview : MonoBehaviour
    {

        void Start()
        {
            //Decleration and Assignment
            var tuple = (1, true);
            Debug.Log(tuple);

            //Decleration and Assignment with Key / Value
            var tuple2 = (Hawyeh: 1, name: "Khaled");
            Debug.Log(tuple2.Hawyeh);
            Debug.Log(tuple2.name);

            // Destructing
            int a;
            bool b;
            (a, b) = tuple;
            Debug.Log(a);
            Debug.Log(b);

            int c = 10;
            int d = 20;

            var (o, f, l) = (1, 2, "Haj Khader");
            (f, o, l) = (1, 2, "Haj Khader");

            Debug.Log(l.GetType());

            Debug.Log(GetPlayer());

        }

        (int, string) GetPlayer()
        {
            return (1, "Subhi");
        }
    }
}
