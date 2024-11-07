using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player3 subhi = new Player3("subhi", 100);
    Player3 ali = new Player3("Ali", 70);

    // Player3 joha = new Player3();

    void Start()
    {
        // subhi.IntializePalyer("Subhi", 100); 
        // Debug.Log(subhi.name + " " + subhi.health);
        // // hjksdfhkjsdfhkjhsdf
        // // sdhjkdshfkjdshf
        // // sdfhgjkdshfjkdshf
        // // subhi.IntializePalyer("Subhi", 95);
        // // ali.IntializePalyer("Ali", 95);
        // Debug.Log(subhi.name + " " + subhi.health);
        Debug.Log("Player Count: " + Player3.playerCount);
        // Debug.Log(joha.name + " " + joha.health);
    }
}
