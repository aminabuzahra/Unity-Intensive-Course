using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math3
{

    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public static string Multiply(string text, int n)
    {
        string result = "";
        for (int i=0; i < n; i++)
        {
            result += text + " ";
        }
        return result;
    }

    public static string Multiply(int n, string text)
    {
        return Multiply (text, n);
    }
}

