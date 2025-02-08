using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lecture24;
using UnityEngine;
using UnityEngine.Animations;

public class StringVsStringBuilder : MonoBehaviour
{
    void Start()
    {
        string name; // Immutables غير قابل للتغيير
        name = "Suib,ihi";

        Debug.Log(name.CompareTo("Ahmad")); // +1
        Debug.Log(name.Contains("bh"));
        Debug.Log(name.EndsWith("i"));
        Debug.Log(name.Equals("Subhi"));  // More Performant 
        Debug.Log(name == "Subhi");
        name.Insert(1, "a");              // Saubhi
        Debug.Log(name.Insert(1, "a"));
        Debug.Log(name.IndexOf("i"));
        Debug.Log(name.LastIndexOf("i"));
        Debug.Log(name.Replace("b", "p"));

        string[] characters = name.Split(",");
        foreach (var n in characters)
        {
            Debug.Log(n);
        }

        Debug.Log("Computer".Substring(1, 3));

        for (int i = 0; i < 10000; i++)
        {
            name += i;
        }

        Debug.Log(name);
        Debug.Log("Hello Subhi".Trim());

        Debug.Log(int.Parse("12") + 1);

        float fNumber;
        float.TryParse("10.5f".Replace("f", ""), out fNumber);
        Debug.Log(fNumber);

        // ==================================
        // StringBuilder // Mutable

        StringBuilder player = new StringBuilder(100000);

        player.Append("Subhi").Append("Matahab").Append("Kif Halkom");

        for (int i = 0; i < 10000; i++)
        {
            player.Append(i.ToString());
            // player.Append(i); Also Correct
        }


        player.AppendFormat("Hello {1}, {0}", "Subhi", "Sameer");

        Debug.Log(player);
        player.Clear();

    }

    void Update()
    {

    }

}
