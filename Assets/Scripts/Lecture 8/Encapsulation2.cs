using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulation2 : MonoBehaviour
{
    void Start()
    {
    //    Player subhi = new Player();
    //    subhi.GetDamage(10);
    //    Debug.Log(subhi.HealthAmount());
    //    subhi.Heal(50);
    //    Debug.Log(subhi.HealthAmount());

    //    subhi.name = "Maqlubeh";
    //    Debug.Log(subhi.name);

    //    subhi.playerExperience = 1;
    //    Debug.Log(subhi.playerExperience);

       // Math2 m = new Math2();
       // Debug.Log(m.Multiply(5,5));

    //    Debug.Log(Math2.Multiply(5,5));
    //    Debug.Log(Math2.name);

    //    Math2 m1 = new Math2();
    //    Math2 m2 = new Math2();

    //    m1.ChangeName("Abbas");

    //    Debug.Log(m2.getName());

       Debug.Log(Math3.Multiply(5,5));
       Debug.Log(Math3.Multiply("Mohammad", 3));
       Debug.Log(Math3.Multiply(5, "Mohammad"));

       Enemy[] enemies = new Enemy[1000];
       for(int i = 0; i < enemies.Length; i++)
       {
          enemies[i].enemyName = "Enemy" + (i+1);
       }

    }
}
