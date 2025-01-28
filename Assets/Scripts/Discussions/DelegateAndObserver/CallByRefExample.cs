using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallByRefExample : MonoBehaviour
{

    int moneyInBank = 0;
    Num num = new Num();
    NumStruct numStruct = new NumStruct();
    void Start()
    {
        IncreaseMoney(5);
        IncreaseMoney(2); // 7

        // IncreaseMoney(5, ref moneyInBank);  // moneyInBank = 12
        IncreaseMoney(5, ref moneyInBank);  // moneyInBank = 12

        // Debug.Log(moneyInBank);

        // num.N = 0;
        // Debug.Log(num.N);
        // IncreaseMoney(1000, num);
        // Debug.Log(num.N);

        // numStruct.Num1 = 0;
        // numStruct.Num2 = new Num();
        // numStruct.Num2.N = 0;

        // Debug.Log(numStruct.Num1);
        // Debug.Log(numStruct.Num2.N);

        // IncreaseMoney(500, numStruct);
        // Debug.Log(numStruct.Num1);
        // Debug.Log(numStruct.Num2.N);


    }

    void IncreaseMoney(int amount)
    {
        moneyInBank += amount;
    }

    void IncreaseMoney(int amount, ref int subhi)
    {
        subhi += amount;
        subhi += amount;
    }

    void IncreaseMoney(int amount, Num n)
    {
        n.N += amount;
    }

    void IncreaseMoney(int amount, NumStruct n)
    {
        n.Num1 += amount;
        n.Num2.N += amount;
    }

}
