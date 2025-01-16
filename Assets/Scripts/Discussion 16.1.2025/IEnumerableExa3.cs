using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class IEnumerableExa3 : MonoBehaviour
{
    void Start()
    {
        AhmadList2 ahmadList = new AhmadList2() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        for (int i = 0; i < ahmadList.Count; i++)
        {
            Debug.Log(ahmadList[i]);
        }

        foreach (int v in ahmadList)
        {
            Debug.Log(v);
        }
    }

    public class AhmadList2 : IEnumerable
    {
        int[] ints = new int[5];
        public int Count
        {
            get;
            set;
        }
        public int Capacity => ints.Length;

        public int this[int index]
        {
            get
            {

                if (index >= 0 && index < ints.Length)
                {
                    return ints[index];
                }
                else
                {
                    throw new System.Exception("Index out of bounds");
                }

            }
            set
            {
                if (index >= 0 && index < ints.Length)
                {
                    ints[index] = value;
                }
                else
                {
                    throw new System.Exception("Index out of bounds");
                }
            }
        }

        public void Add(int v)
        {
            if (Count >= ints.Length)
            {
                int[] temp = new int[ints.Length * 2];
                for (int i = 0; i < ints.Length; i++)
                {
                    temp[i] = ints[i];
                }
                ints = temp;
            }
            ints[Count++] = v;
        }

        IEnumerator GetEnumerator()
        {
            for (int i = 0; i < ints.Length; i++)
            {
                yield return ints[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
