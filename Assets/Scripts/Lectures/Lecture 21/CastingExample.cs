using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngineInternal;

namespace Lecture21
{
    public class CastingExample : MonoBehaviour
    {
        int num = 50;
        float fNum = 10.999999f;

        void Start()
        {
            num = (int)fNum;    // Explicit type conversion 
            // Debug.Log(num);
            fNum = num + 0.1f;  // Implicit type conversion
            Debug.Log(fNum);

            Sword sword = new Sword();
            Rifle rifle = new Rifle();

            Weapon weapon = new Weapon();

            Subhi subhi;

            // Weapon weapon = sword;    // Upcasting, Implicit 

            // rifle = (Rifle)weapon;    // Downcasting, Explicit
            rifle.RifleType = "M16";
            // Debug.Log(rifle.RifleType);

            // sword = (Sword)rifle;  // Wrong !!!

            // if (sword is Weapon)
            // {
            //     Debug.Log("Yes it is a Sword");
            // }

            // if (weapon is Sword)
            // {
            //     Debug.Log("Subhi");
            // }

            // if (rifle is Sword)
            // {
            //     Debug.Log("Abbas");
            // }

            // if (5.0 is float)
            // {
            //     Debug.Log("Integer");
            // }

            // subhi = (Subhi)weapon; // Worng

            Weapon sword3 = new Sword(); // Widening
            sword3.printData();

            Weapon weapon1 = new Weapon();
            Sword sword4 = (Sword)weapon1; // Narrowing


            // ------------
            Weapon w = new Weapon();
            Sword s = new Sword();
            Rifle r = new Rifle();

            // Boxing and Unboxing

            object o = "Subhi";      // Boxing !!!!!!!
            object o2 = 10;

            string o3 = (string)o;   // Unboxing  !!!!!!!!
            // Generic or Interfaces.
            // =====================

            // Layla & Al-Hasan

            // Syntax of as
            // Weapon s2 = (Weapon)s;
            Weapon s2 = s as Weapon;

            Sword ssss = (Sword)w;  // Old Fashion
            Sword sss = w as Sword;  // New Fashion



        }

        class Weapon
        {
            private int a = 10;

            public int A
            {
                get { return a; }
                set { A = value; }
            }
            public string WeaponName { get; set; }

            public virtual void printData()
            {
                Debug.Log(WeaponName);
            }
        }

        class Sword : Weapon
        {
            public string SwordType = "Normal Sword";
            void Slash()
            {
                Debug.Log("Slash");
            }

            public override void printData()
            {
                Debug.Log(SwordType);
            }
        }

        class Rifle : Weapon
        {
            public string RifleType;
            void Shoot()
            {
                Debug.Log("Shoot");
            }
        }

        class Subhi
        {

        }
    }
}
