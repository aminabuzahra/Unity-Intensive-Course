using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Lecture23
{
    public class ActionExample2 : MonoBehaviour
    {

        List<int> listOfNumbers = new List<int> { 2, 7, 16, 5 };

        List<int> filteredList;
        List<string> filteredList2;


        List<string> raedList = new List<string> { "Raed", "Badriyeah", "Im Subhi" };
        // Action<int, int, string> action;

        // Func<int, int, int> func;

        // Func<int> func2;

        Predicate<int> predicate;




        void Start()
        {
            predicate = isOdd;

            filteredList = listOfNumbers.FindAll(predicate);
            filteredList2 = raedList.FindAll(checkString);

            // action = abc;
            // executeFunc(compareValues);
        }


        bool isOdd(int i)
        {
            return i % 2 == 1;
        }

        // void abc(int a, int b, string str)
        // {
        //     Debug.Log("Subhi");
        // }

        // int summation(int a, int b)
        // {
        //     return a + b;
        // }

        // int xyz()
        // {
        //     return 1;
        // }

        bool compareValues(int a, int b)
        {
            return a < b;
        }

        bool checkString(string str)
        {
            return str == "Raed";
        }


        void executeFunc(Func<int, int, bool> khader)
        {
            Debug.Log(khader(1, 2));
        }


    }
}
