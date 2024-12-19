using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AwsUtilites
{
    public static class MethodsExtensions
    {
        public static Transform[] GetChildren(this Transform parent)
        {
            int childCount = parent.childCount;
            Transform[] children = new Transform[childCount];
            for (int i = 0; i < childCount; i++)
            {
                children[i] = parent.GetChild(i);
            }
            return children;
        }
    }
}
