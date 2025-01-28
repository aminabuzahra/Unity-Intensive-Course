using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class FindObjects : MonoBehaviour
{
    void Start()
    {
        Light light = GameObject.FindFirstObjectByType<Light>();
        print(light.name);
    }
}
