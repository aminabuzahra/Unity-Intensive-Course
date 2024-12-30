using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomList : MonoBehaviour
{
    List<int> numbers = new List<int>() { 1, 3, 4, 5 };

    RozanList<int> rozanList = new RozanList<int>() { 1, 3, 4, 5 };

    // dynamic-sized list : The size is dynamic 0 ==> infinity

    void Start()
    {
        for (int i = 0; i < numbers.Count; i++)
            print(numbers[i]);

        for (int i = 0; i < rozanList.Count; i++)
            print(rozanList[i]);
    }

    public class RozanList<T> : IEnumerable<T>
    {
        // indexing of classes i.e rozanList[i]

        public T this[int i]  // property for indexing the class
        {
            get
            {
                if (i < 0 || i >= Count)
                    throw new Exception("Index Out of range");
                return data[i];
            }

            set
            {
                if (i < 0 || i >= Count)
                    throw new Exception("Index Out of range");
                data[i] = value;
            }
        }

        T[] data = new T[4];

        public int Count = 0;

        public int Capacity = 4;

        public void Add(T value)
        {
            if (Count >= data.Length)
            {
                Capacity *= 2;
                T[] temp = new T[Capacity];

                // Copying
                // data.CopyTo(temp, 0);
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }

                data = temp;
            }
            data[Count++] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
