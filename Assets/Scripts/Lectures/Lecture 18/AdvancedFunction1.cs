using UnityEngine;

namespace Lecture18
{
    public class AdvancedFunction1 : MonoBehaviour
    {
        int number = 0;

        int weatherDegree;

        playerStruct players;

        string[] names = new string[10];

        int num1 = 10;
        int num2 = 20;
        void Start()
        {
            // Debug.Log(addNumbers(1, 2));
            // Debug.Log(addNumbers(new int[] { 1, 2, 3, 4, 5 }));
            // Debug.Log(addNumbers(1, 2, 3, 5, 6, 7, 8, 9, 10, 11));
            // Debug.Log(addNumbers());
            // printNameAndScore(ability: "Double Jump", score: 1350);
            // increment(ref number);
            //  Debug.Log(number);

            players = new playerStruct
            {
                name1 = "subhi",
                name2 = "abbas",
                name3 = "khader",
                name4 = "mahmoud"
            };

            structChangeNames(ref players);
            // printPlayerStruct(players);

            swapNumbers(ref num1, ref num2);
            // Debug.Log(num1);
            // Debug.Log(num2);


            // changeNames(names);
            // printNames(names);

            whatIstWeatherDegree(ref weatherDegree);
            Debug.Log(weatherDegree);
        }

        // ref, out, in : passing by reference. Passing by values (primitives, struct) exept objects which are passed by reference BY DEFAULT
        void swapNumbers(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        void whatIstWeatherDegree(ref int wd)
        {
            wd = Random.Range(0, 10);  // readonly
        }

        void structChangeNames(ref playerStruct plyrs)
        {
            plyrs.name1 = "Orange";
            plyrs.name2 = "Apple";
            plyrs.name3 = "Mango";
            plyrs.name4 = "Watermelone";
        }

        void printPlayerStruct(playerStruct plyrs)
        {
            Debug.Log(plyrs.name1);
            Debug.Log(plyrs.name2);
            Debug.Log(plyrs.name3);
            Debug.Log(plyrs.name4);
        }

        void changeNames(string[] playerNames)
        {
            for (int i = 0; i < playerNames.Length; i++)
            {
                playerNames[i] = "Ibrahim";
            }
        }

        void printNames(string[] playerNames)
        {
            foreach (string name in playerNames)
            {
                Debug.Log(name);
            }
        }

        void printNameAndScore(int score, string name = "No Name", string ability = "Dash")
        {
            Debug.Log(name + ": " + score + ", " + ability);
        }

        // Parameters Exa: score name ability
        // Arguments Exa: 1350 Subhi Dash

        int addNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        int addNumbers(params int[] numbers)
        {
            int total = 0;
            if (numbers.Length > 0)
            {
                foreach (int num in numbers)
                {
                    total += num;
                }
            }
            return total;
        }

        string addNumbers(string name, bool checkbox, params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return name + total;
        }

        void addStrings<T>(params T[] things)
        {
            foreach (T onething in things)
            {
                Debug.Log(onething);
            }
        }
    }
}
