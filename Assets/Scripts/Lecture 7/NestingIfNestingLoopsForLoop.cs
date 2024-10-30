using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NestingIfNestingLoopsForLoop : MonoBehaviour
{
    void Start()
    {
        // Nested while loop
        // int i = 1;
        // int j = 1;
        // while (i <= 12)
        // {
        //     while (j <= 12)
        //     {
        //         Debug.Log (i * j); 
        //         j++;
        //     }
        //     j = 1;
        //     i++;
        // }

        // i = 13
        // j = 1;
        

        // Nested If
        // if (i != j) 
        // {
        //     Debug.Log("Tamam");
        //     if (i > j)
        //     {
        //         Debug.Log ("i < j");
        //     }
        // }
        // 

        // While Vs. For Loop

        // int ii = 1;
        // while (ii <= 12)
        // {
        //     Debug.Log (ii); 
        //     ii++;
        // }
        

        // For Loop
        // for (int x = 1; x <= 12; x++) 
        // {
        //     Debug.Log (x);  
            
        // }


        // for (int i = 1; i <= 12; i++)
        // {
        //     for (int j = 1; j <= 12; j++)
        //     {
        //         Debug.Log (i * j); 
        //     }
        // }


        string[] name = { "Subhi", "Khamis", "Sabri", "Badrieh", "Jumaah"};
        for (int i = 0; i < name.Length; i++)
        {
            Debug.Log(name[i]);
            if (i == 3) continue;
            Debug.Log("Hello");
        }

        // 0001001000100110010001010010100010010010101000010
        // 0100100101010101010010101010010101010101010101010

        
        
    }
}
