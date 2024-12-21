using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListSorting : MonoBehaviour
{
    List<int> numbers = new List<int>() { 12, 4, 24, 16, 37 };
    void Start()
    {
        numbers.Sort(Descending);

        foreach (var number in numbers)
        {
            Debug.Log(number);
        }
    }

    int Descending(int a, int b)
    {
        return b.CompareTo(a);
    }
}
