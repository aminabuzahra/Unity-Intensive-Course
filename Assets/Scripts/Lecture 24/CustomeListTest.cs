using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Lecture24
{
    public class CustomeListText : MonoBehaviour
    {
        List<int> ints = new List<int>() { 1, 2, 3, 4 };

        RaedList<int> raedList = new RaedList<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        void Start()
        {
            for (int i = 0; i < raedList.Count; i++)
            {
                print(raedList[i]);
            }

            foreach (var n in raedList)
            {
                print(n);
            }

            // print(ints.Capacity);
            // ints.Add(5);
            // ints.Add(5);
            // ints.Add(5);
            // ints.Add(5);
            // ints.Add(5);
            // print(ints.Capacity);

            // for (int i = 0; i < ints.Count; i++)
            // {
            //     print(ints[i]);
            // }

            // foreach (int num in ints)
            // {
            //     print(num);
            // }
        }
    }

    public class RaedList<T> : IEnumerable<T>
    {
        T[] _values = new T[4];
        int _count = 0;
        int _capacity = 4;

        public T this[int index]
        {
            get => _values[index];
            set => _values[index] = value;
        }
        public int Count
        {
            get => _count;
            private set => _count = value;
        }

        public int Capacity
        {
            get => _capacity;
            private set => _capacity = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public void Add(T v)
        {
            if (Capacity >= _values.Length)
            {
                T[] tempArr = new T[Capacity * 2];

                for (int i = 0; i < _values.Length; i++)
                {
                    tempArr[i] = _values[i];
                }

                _values = tempArr;

                Capacity *= 2;
            }
            _values[Count++] = v;
        }
    }
}


