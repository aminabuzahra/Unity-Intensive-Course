using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture25
{
    public class ListExtension : MonoBehaviour
    {
        void Start()
        {
            List<int> values = new List<int>();
            List<AsarAlHisbeh> prices = new List<AsarAlHisbeh>() { new AsarAlHisbeh(30), new AsarAlHisbeh(10), new AsarAlHisbeh(20) };
            for (int i = 0; i < 10; i++)
            {
                values.Add(UnityEngine.Random.Range(0, 100));
            }

            // print(string.Join(", ", values));

            // values.BubbleSort((int a, int b) => a.CompareTo(b));
            // print(string.Join(", ", values));

            // values.BubbleSort((int a, int b) => b.CompareTo(a));
            // print(string.Join(", ", values));

            print(string.Join(", ", prices));
            // prices.Sort();
            prices.BubbleSort((AsarAlHisbeh a, AsarAlHisbeh b) => a.CompareTo(b));
            print(string.Join(", ", prices));
        }
    }

    public static class ListHelper
    {
        public static void BubbleSort<T>(this List<T> list, Func<T, T, int> CompareTo)
        {
            T[] data = list.ToArray();
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
            list.Clear();
            list.AddRange(data);
        }
    }

    public class AsarAlHisbeh : IComparable
    {
        int price = 0;
        public AsarAlHisbeh(int price)
        {
            this.price = price;
        }

        public int CompareTo(object obj)
        {
            return price.CompareTo((obj as AsarAlHisbeh).price);
        }

        public override string ToString()
        {
            return price.ToString();
        }
    }
}
