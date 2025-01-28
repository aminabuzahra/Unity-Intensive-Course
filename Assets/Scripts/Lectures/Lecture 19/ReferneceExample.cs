using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ReferneceExample : MonoBehaviour
{
    string fn;
    string ln;

    void Start()
    {
        changeFirstAndLastName(ref fn, ref ln);
        Debug.Log($"{fn} {ln}");
        changeNames(ref fn);
        Debug.Log($"{fn} {ln}");
    }

    void changeFirstAndLastName(ref string FirstName, ref string LastName)
    {
        FirstName = "Raed";
        LastName = "Abu Dayeh";
    }

    void changeNames(ref string name)
    {
        name = "Subhi";
    }
}
