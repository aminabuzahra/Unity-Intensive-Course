using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marah : MonoBehaviour
{
    Car marahCar = new Car();

    void Start()
    {
        marahCar.color = "yellow";
        Debug.Log(marahCar.color);

        marahCar.IdAsBanzin(50);
        Debug.Log(marahCar.speed);
        marahCar.IdAsBanzin(50);
        Debug.Log(marahCar.speed);

        marahCar.IdAsBreak();
        Debug.Log(marahCar.speed);  

    }
}
