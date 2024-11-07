using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
  void Start()
  {
    int i = 5;
    while (true)
    {
      Debug.Log("Tamam");
      if (i == 5) break;
    }

    string[] name = { "Subhi", "Khamis", "Sabri" };

    Debug.Log(name[1]);

    Debug.Log(name.Length);

    string fullName = name[0] + " " + name[1];
    Debug.Log(fullName);
  }
}
