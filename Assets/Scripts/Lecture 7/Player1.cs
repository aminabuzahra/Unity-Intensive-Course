using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;

public class Player1 
{
    string name;
    int health;

    void PrintPlayerName()
    {
        Debug.Log(name);
    }

    void AddHealth(int value)
    {
        health = health + value;
        // health += value;
    }

    void SubtractHealth(int value)
    {
        health = health - value;
        // health -= value;
    }
}
