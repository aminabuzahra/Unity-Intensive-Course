using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lecture20;
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
            myDictionary.Add("Tesla", 250_000);
            myDictionary["BMW"] = 500_000;
            myDictionary["BMW"] = 200_000; // **

            myDictionary.FindAllValues((num) => num >= 1000 && num <= 250_000).printList();

            // List<int> ints = myDictionary.Values.ToList<int>();
            // ints = ints.FindAll((num) => num >= 1000 && num <= 250_000);
            // ints.printList<int>();

            // foreach (var n in ints)
            // {
            //     Debug.Log(n);
            // }


            // foreach (var car in myDictionary)
            // {
            //     if (car.Value >= 1000 && car.Value <= 250_000)
            //     {
            //         Debug.Log($"We found car {car.Key} has the price of {car.Value}");
            //     }
            // }

            // Debug.Log(myDictionary["Tesla"]);
            // int p;
            // if (myDictionary.TryGetValue("Simca", out p))
            // {
            //     Debug.Log(p);
            // }

            try
            {
                int c = 0;
                int a = 1 / c;

                Debug.Log(myDictionary["Simca"]); // Wrong Wrong Wrong !!!!
            }

            catch (DivideByZeroException e1)
            {
                Debug.LogError($"Divide by Zero ya Habibi !! {e1.Message}");
            }
            catch (KeyNotFoundException e2)  // Cleaner Code, 
            {
                Debug.LogError($"Exception type: {e2.GetType()}, and the message is: {e2.Message}");
                // Debug.LogError($"Key not found!! {e2.Message}");
            }
            finally
            {
                Debug.Log("In all cases we did not abort the execution of the program");
            }

            foreach (var v in myDictionary.Values)
            {
                Debug.Log(v);
            }

            foreach (KeyValuePair<string, int> car in myDictionary)
            {
                // Debug.Log(car);
                // Debug.Log(car.Key);
                // Debug.Log(car.Value);
            }

            // myDictionary2.Add(1, "Subhi");
            // myDictionary2.Add(2, "Abbas");
            // myDictionary2.Add(3, "Khader");
            // myDictionary2.Add(4, "Khamis");

            // foreach (KeyValuePair<string, int> pair in myDictionary)
            // {
            //     Debug.Log(pair);
            // }

            // foreach (string carName2 in myDictionary.Keys)
            // {
            //     Debug.Log(carName2);
            // }
            // foreach (int price2 in myDictionary.Values)
            // {
            //     Debug.Log(price2);
            // }

            // Debug.Log(myDictionary["Fiat"]);
            // myDictionary["Fiat"] += 5;
            // Debug.Log(myDictionary["Fiat"]);

            // // 1
            // string carName = "Fiat";
            // if (myDictionary.ContainsKey(carName))
            // {
            //     myDictionary[carName] += 5;
            // }
            // else
            // {
            //     myDictionary.Add(carName, 300_000);
            // }

            // Debug.Log(carName + " " + myDictionary[carName]);

            // // 2
            // int price;
            // if (myDictionary.TryGetValue(carName, out price))
            // {
            //     Debug.Log(price);
            // }
            // else
            // {
            //     Debug.Log("Car Not Found");
            // }

            // myDictionary2.Remove(2);

            // foreach (var pair in myDictionary2)
            // {
            //     Debug.Log(pair);

            // }

            // Debug.Log(myDictionary2[3]);
        }

        void Update()
        {

        }
    }
}