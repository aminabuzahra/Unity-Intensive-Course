using System.Collections;
using System.Collections.Generic;
using Unity.Android.Types;
using UnityEngine;

public class Player 
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
