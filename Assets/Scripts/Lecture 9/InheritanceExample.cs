using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceExample : MonoBehaviour
{
    Sharshabeel sharshabeel = new Sharshabeel();
    void Start()
    {
           sharshabeel.name = "Sharshabeel";
           sharshabeel.printEnemyName();
           sharshabeel.EatSanfoor();
    }
}
