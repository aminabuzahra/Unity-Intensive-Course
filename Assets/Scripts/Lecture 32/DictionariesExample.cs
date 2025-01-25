using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Lecture32
{
    public class DictionariesExample : MonoBehaviour
    {
        // Array (1,2,3)
        // List (1,2,3, ...)
        // Tuple (1, "Khader")
        // Dictionary (key1, value1), (key2, value2), ...
        void Start()
        {
            // var myDictionary = new Dictionary<string, int>();
            // Dictionary<string, int> myDictionary = new();
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            Dictionary<int, string> myDictionary2 = new Dictionary<int, string>();

            myDictionary.Add("Mercedes", 1_000_000);
            myDictionary.Add("Fiat", 1_000);
            myDictionary.Add("Maybach", 10_000_000);
            myDictionary.Add("Tesla", 200_000);

            myDictionary2.Add(1, "Subhi");
            myDictionary2.Add(2, "Abbas");
            myDictionary2.Add(3, "Khader");
            myDictionary2.Add(4, "Khamis");

            foreach (KeyValuePair<string, int> pair in myDictionary)
            {
                Debug.Log(pair);
            }

            foreach (string carName2 in myDictionary.Keys)
            {
                Debug.Log(carName2);
            }
            foreach (int price2 in myDictionary.Values)
            {
                Debug.Log(price2);
            }

            Debug.Log(myDictionary["Fiat"]);
            myDictionary["Fiat"] += 5;
            Debug.Log(myDictionary["Fiat"]);

            // 1
            string carName = "Fiat";
            if (myDictionary.ContainsKey(carName))
            {
                myDictionary[carName] += 5;
            }
            else
            {
                myDictionary.Add(carName, 300_000);
            }

            Debug.Log(carName + " " + myDictionary[carName]);

            // 2
            int price;
            if (myDictionary.TryGetValue(carName, out price))
            {
                Debug.Log(price);
            }
            else
            {
                Debug.Log("Car Not Found");
            }

            myDictionary2.Remove(2);

            foreach (var pair in myDictionary2)
            {
                Debug.Log(pair);

            }

            Debug.Log(myDictionary2[3]);
        }

        void Update()
        {

        }
    }
}