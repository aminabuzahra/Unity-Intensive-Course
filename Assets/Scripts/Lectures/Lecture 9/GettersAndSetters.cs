using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class GettersAndSetters : MonoBehaviour
{
    // Encapsulation:
    // private string name = "Subhi";  // Field
    public int a = 10; // Field
 
    public int A = 20; // Field

    public int[] enemies = new int[10];

    // Properties:

    [SerializeField]
    private string password = "Toz"; // Field

    public string Password     // Property 
    {
        get 
            { 
              return password;  
            }
        set { 
               password = value;
               PasswordWasChanged();
            }                             
    }

    private int energry = 50;
    public int Energy
    {
        get { return energry;}
        set { energry = value; }
    }

    private int health = 100;

    public int Health  // Property
    {
        get { return health;}
        set { if (value> 100) health = 100;
              else if (value < 0) health = 0;
              else health = value;
            }
    }

        // public void Password (string value)
        // {
        //      password = value;
        // }

    void Start()
    {
        // Password = "abc";
        // Debug.Log(Password);  

        // Health = 110;       // set
        // Debug.Log(Health);  // get


        // Energy = 10;
        Debug.Log(Energy);

        
        Debug.Log(enemies.Length);

        // Debug.Log (Password);
    }

    public void PasswordWasChanged()
    {
        Debug.Log("Password was Changed");
    }

    public string getPassword()
    {
        return password;
    }

    public void setPassword(string value)
    {
        password = value;
    }

}
