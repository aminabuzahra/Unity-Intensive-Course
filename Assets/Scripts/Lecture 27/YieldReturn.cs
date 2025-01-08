using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture27
{
    public class YieldReturn : MonoBehaviour
    {
        void Start()
        {
            IEnumerator enumerator = generateNumber();

            while (enumerator.MoveNext())
            {
                Debug.Log("Current is: " + enumerator.Current);
            }

            // enumerator.MoveNext(); // true
            // Debug.Log("Current is: " + enumerator.Current);

            // enumerator.MoveNext(); // true
            // Debug.Log("Current is: " + enumerator.Current);

            // enumerator.MoveNext(); // false
            // Debug.Log("Current is: " + enumerator.Current);

        }

        void Update()
        {

        }

        IEnumerator generateNumber()
        {
            int i = -1;
            Debug.Log("Before the first yield");
            i++;
            yield return 1;

            Debug.Log("I reached 2");
            Debug.Log("***********");
            Debug.Log("***********");
            Debug.Log("***********");
            Debug.Log("***********");
            Debug.Log("***********");
            Debug.Log("***********");
            Debug.Log("***********");
            Debug.Log("***********");
            i++;

            if (i == 1)
                yield break;

            yield return 2;
            Debug.Log("Subhi");
            Debug.Log("Abass");

            i++;
            Debug.Log(i);
            yield return 3;
            Debug.Log("Finsihed method");
        }
    }
}
