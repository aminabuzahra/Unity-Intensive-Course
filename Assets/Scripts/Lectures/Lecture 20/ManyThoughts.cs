using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture20
{
    public class ManyThoughts : MonoBehaviour
    {

        Player player = new Player("Madiha");


        int age = 26;

        void Start()
        {
            // Debug.Log("Hello from Battikha");
            // print("Hello from Subhi");

            // Debug.Log("The name of the player is: " + player + " and his age is: " + age + " years.");

            // print($"The name of the player is: {player} and her age is: {age} years.");

            // var player2 = new Player("Makloubeh", 40);

            // dynamic a;

            // List<string> numbers = new List<string> { "1", "2", "3" };

            // foreach (var num in numbers)
            // {
            //     print(num);
            // }

            player.Health = 49;
            print($"The name of the player is: {player} and her age is: {age} years. And her status is {player.getStatus()}");

            StaticClass.enhancedPrint("Subhi");


        }

        void Update()
        {

        }
    }
}
