using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture28
{
    public class Transform2 : MonoBehaviour
    {
        void Start()
        {

            // Child (1)
            GameObject gameObject = GameObject.Find("God Father");
            // GameObject gameObject = GameObject.Find("God Father");

            // for (int i = 0; i < gameObject.transform.childCount; i++)
            // {
            //     Debug.Log(gameObject.transform.GetChild(i).name);
            // }

            foreach (Transform child in gameObject.transform)
            {
                Debug.Log(child.name);
            }

            GameObject almunshaq = GameObject.Find("Khamis");

            almunshaq.transform.SetParent(GameObject.Find("Albandora").transform);
        }
    }
}
