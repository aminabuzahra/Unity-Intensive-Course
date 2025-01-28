using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture25
{
    public class ListSort : MonoBehaviour
    {
        void Start()
        {
            CustomList<int> cList = new CustomList<int>();
            CustomList<string> cList2 = new CustomList<string>();
            for (int i = 0; i < cList.data.Length; i++)
            {
                cList.data[i] = UnityEngine.Random.Range(0, 100);
            }

            cList2.data[0] = "Saja";
            cList2.data[1] = "Abel Ra'ouf";
            cList2.data[2] = "Mohammad";
            cList2.data[3] = "Ahmad";
            cList2.data[4] = "Alaa";
            cList2.data[5] = "Alhasan";
            cList2.data[6] = "Raed";
            cList2.data[7] = "Basmallah";
            cList2.data[8] = "Layla";
            cList2.data[9] = "Omar";
            cList2.data[10] = "Rozan";
            cList2.data[11] = "Lemara";
            cList2.data[12] = "Amjad";
            cList2.data[13] = "Bader";
            cList2.data[14] = "Abdelnasser";
            cList2.data[15] = "Reem";
            cList2.data[16] = "Sojood";
            cList2.data[17] = "Israa";
            cList2.data[18] = "Nidaa";
            cList2.data[19] = "Nahla";
            cList2.data[20] = "Abdallah";

            Debug.Log(cList2.data[UnityEngine.Random.Range(0, 21)]);

            //    print ("Subhi".CompareTo("Khader"));

            // print(string.Join(", ", cList.data));

            // List<int> list = new List<int>();
            // list.AddRange(cList.data);
            // list.Sort();

            // list.Sort((int a, int b) => a > b ? (a == b ? 0 : 1) : -1);

            // list.Sort((int a, int b) => b.CompareTo(a));

            // print(string.Join(", ", cList));

            cList.Sort((int a, int b) => b.CompareTo(a)); // تنازلي

            cList2.Sort((string a, string b) => a.CompareTo(b)); // تصاعدي

            // cList2.Sort(CompareTo);

            print(string.Join(", ", cList.data));
            print(string.Join(", ", cList2.data));
        }

        // int CompareTo(string a, string b)
        // {
        //     return a.CompareTo(b);
        // }
    }

    public class CustomList<T>
    {
        public T[] data = new T[21];

        // Bubble -- Bad 
        // O(n^2)

        public void Sort(Func<T, T, int> CompareTo)
        {
            for (int j = 0; j < data.Length; j++)
            {
                for (int i = 0; i < data.Length - j - 1; i++)
                {
                    if (CompareTo(data[i], data[i + 1]) >= 1)
                    {
                        T temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                    }
                }
            }
        }
    }
}