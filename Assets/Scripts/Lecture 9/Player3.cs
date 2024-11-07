using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player3
{

    public string name;
    public int health = 0;
    public static int playerCount = 0;
    public Player3(string name, int health)
    {
        this.name = name;
        this.health = health;
        playerCount++;
    }

    // public Player3()
    // {
    //     name = "";
    //     health = 100;
    //     playerCount++;
    // }

    public Player3() : this("", 100)
    {
    }

    // public void IntializePalyer(string playerName, int playerHealth)
    // {
    //     name = playerName;
    //     health = playerHealth;
    //     playerCount++;
    // }
}
