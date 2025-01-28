using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car 
{
    public string name = "Fiat";
    public string model = "1995";
    public string color ="pink";

    public int speed = 0;
    
    public bool engineOn = false;

    public void SwitchOn()
    {
        engineOn = true;
        Debug.Log("Car turned On");
    }

    public void SwitchOff()
    {
        engineOn = false;
        Debug.Log("Car turned Off");
    }

    public void IdAsBanzin(int value)
    {
        speed = speed + value;
    }

    public void IdAsBreak()
    {
        speed = 0;
    }

    public int SpeedOmeter()
    {
        return speed;
    }
}
