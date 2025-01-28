using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPIntro : MonoBehaviour
{
    void Start()
    {
        Subhi();
        Subhi();

        int t = TTTime();
        Debug.Log(t);

        int s = AddNumbers(1,2);
        Debug.Log(s);

        // Debug.Log(AddNumbers(1,2));
    }

    void Subhi()
    {
        Debug.Log("Subhi");
    }

    int TTTime()
    {
        return 7;
    }

    int AddNumbers (int number1, int number2)
    {
        int sum = number1 + number2;
        return sum;
    }
}
