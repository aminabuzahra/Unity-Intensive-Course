using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

namespace Lecture21
{
    public class ObjectTypeExample : MonoBehaviour
    {
        void Start()
        {
            Player a = new Player("Subhi");
            Player b = new Player("Subhi");

            // if (a.Equals(b))
            if (a == b)
            {
                Debug.Log("The Same Player");
            }
        }

        class Player
        {
            public string name;

            public Player(string name)
            {
                this.name = name;
            }

            // public override bool Equals(object obj)
            // {
            //     Player a = obj as Player; // Trying to cast it // Unboxing
            //     if (a == null)
            //     {
            //         return false;
            //     }

            //     if (this.name == a.name)
            //     {
            //         return true;
            //     }
            //     return false;
            // }

            public static bool operator ==(Player p1, Player p2)
            {
                if (!p1.Equals(null) && !p2.Equals(null))
                {
                    if (p1.name.Equals(p2.name)) return true;
                }
                return false;
            }

            public static bool operator !=(Player p1, Player p2)
            {
                if (!p1.Equals(null) && !p2.Equals(null))
                {
                    if (!p1.name.Equals(p2.name)) return true;
                }
                return false;
            }
        }
    }
}
