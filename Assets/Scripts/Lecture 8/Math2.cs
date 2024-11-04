using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math2
{
    static public string name = "Subhi";
    static public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    public void ChangeName(string newName)
    {
        name = newName;
    }
    
    public string getName()
    {
       return name;
    }

    
}
