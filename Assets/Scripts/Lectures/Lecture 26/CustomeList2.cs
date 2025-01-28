using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture26
{
    public class CustomeList2 : MonoBehaviour
    {
        void Start()
        {
            BaderList<int> baderList = new() { 1, 2, 3, 4, 5, 6 };

            //    List<int> originalList = new() { 1, 2, 3, 4, 5 };

            //     foreach (var num in originalList)
            //     {
            //         Debug.Log(num);
            //     }

            //     // equivelant to foreach
            //     IEnumerator<int> pointer = originalList.GetEnumerator();
            //     while (pointer.MoveNext())
            //     {
            //         Debug.Log(pointer.Current);
            //     }

            baderList.Sort((x, y) => y.CompareTo(x));

            for (int i = 0; i < baderList.Count; i++)
            {
                Debug.Log(baderList[i]);
            }

            foreach (var num in baderList)
            {
                Debug.Log(num);
            }

            // IEnumerator<int> pointer = baderList.GetEnumerator();
            // while (pointer.MoveNext())
            // {
            //     Debug.Log(pointer.Current);
            // }
        }
    }

    public class BaderList<T> : IEnumerable<T> // Collection - exa: Playlist of Spotify
    {
        T[] _values = new T[4];
        int _capacity = 4;
        int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }

            private set
            {
                _count = value;
            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _capacity = value > _capacity ? value : _capacity;
            }
        }

        public T this[int index]
        {
            get
            {
                return _values[index];
            }

            set
            {
                _values[index] = value;
            }
        }

        public void Add(T item)
        {
            if (Count >= Capacity)
            {
                Capacity *= 2;
                T[] _temp = new T[Capacity];
                _values.CopyTo(_temp, 0);
                _values = _temp;

                /*
                for (int i = 0; i < _values.Length; i++)
                {
                    _temp[i] = _values[i];
                }
                */
            }
            _values[_count++] = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _values[i];
            }
            // return new BaderListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public void Sort(Func<T, T, int> CompareTo)
        {
            for (int j = 0; j < Count - 1; j++)
            {
                bool swapped = false;
                for (int i = 0; i < Count - j - 1; i++)
                {
                    if (CompareTo(_values[i], _values[i + 1]) >= 1)
                    {
                        T temp = _values[i];
                        _values[i] = _values[i + 1];
                        _values[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }

        private class BaderListEnumerator : IEnumerator<T>
        {
            BaderList<T> baderList;
            int index = -1;

            public BaderListEnumerator(BaderList<T> list)
            {
                baderList = list;
            }

            public T Current
            {
                get
                {
                    return baderList._values[index];
                }
            }

            // public T current => baderList._values[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                return (++index) < (baderList.Count);
            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
