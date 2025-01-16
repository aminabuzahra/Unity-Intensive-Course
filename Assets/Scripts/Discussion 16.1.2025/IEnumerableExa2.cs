using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class IEnumerableExa2 : MonoBehaviour
{
    void Start()
    {
        AhmadList ahmadList = new AhmadList(1, 2, 3, 4, 5);

        // List<int> ahmadList2 = new List<int> { 1, 2, 3, 4, 5 };
        // Debug.Log(ahmadList.v1);
        // Debug.Log(ahmadList.v2);
        // Debug.Log(ahmadList.v3);
        // Debug.Log(ahmadList.v4);
        // Debug.Log(ahmadList.v5);

        // for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log(ahmadList[i]);
        // }

        foreach (int v in ahmadList)
        {
            Debug.Log(v);
        }

        // for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log(ahmadList2[i]);
        // }

        // foreach (int v in ahmadList2)
        // {
        //     Debug.Log(v);
        // }

    }

    public class AhmadList : IEnumerable
    {
        public int v1;
        public int v2;
        public int v3;
        public int v4;
        public int v5;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return v1;
                    case 1: return v2;
                    case 2: return v3;
                    case 3: return v4;
                    case 4: return v5;
                    default: throw new System.Exception("Index out of bounds");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        v1 = value;
                        break;
                    case 1:
                        v2 = value;
                        break;

                    case 2:
                        v3 = value;
                        break;

                    case 3:
                        v4 = value;
                        break;

                    case 4:
                        v5 = value;
                        break;
                    default: throw new System.Exception("Index out of bounds");
                }
            }
        }

        public AhmadList(int v1, int v2, int v3, int v4, int v5)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
        }

        IEnumerator GetEnumerator()
        {
            yield return v1;
            yield return v2;
            yield return v3;
            yield return v4;
            yield return v5;
            
            // return new AhmadListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // class AhmadListEnumerator : IEnumerator
        // {
        //     AhmadList ahmadList1;
        //     int index = -1;

        //     object IEnumerator.Current => ahmadList1[index];

        //     public AhmadListEnumerator(AhmadList ahmadList)
        //     {
        //         this.ahmadList1 = ahmadList;
        //     }
        //     public bool MoveNext()
        //     {
        //         index++;
        //         if (index > 4)
        //             return false;
        //         else if (index > -1)
        //             return true;
        //         return false;
        //     }

        //     public void Reset()
        //     {
        //         index = -1;
        //     }
        // }
    }
}
