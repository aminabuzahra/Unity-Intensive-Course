using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulation : MonoBehaviour
{
    Car SiaretAbedelNasser = new Car(); 
    void Start()
    {
        Debug.Log(SiaretAbedelNasser.engineOn);
        SiaretAbedelNasser.SwitchOn();
        Debug.Log(SiaretAbedelNasser.engineOn);
        Debug.Log(SiaretAbedelNasser.name);
        SiaretAbedelNasser.name = "Rolls Royce";
        Debug.Log(SiaretAbedelNasser.name);
    }
}
