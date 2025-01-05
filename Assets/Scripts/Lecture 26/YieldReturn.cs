using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture26
{
    public class YieldReturn : MonoBehaviour
    {
        void Start()
        {
            IEnumerator enumerator = find(5);
            while (enumerator.MoveNext())
            {
                Debug.Log(enumerator.Current);
            }
        }

        IEnumerator find(int value)
        {
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
        }
        // IEnumerator find(int value)
        // {
        //     for (int i = 0; i < 1000; i++)
        //     {
        //         if (i == value) yield break;
        //         yield return i;
        //     }
        // }
    }
}
