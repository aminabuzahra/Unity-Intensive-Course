using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture45
{
    public class HerosSpawner : MonoBehaviour
    {
        // [SerializeField]
        GameObject Hero;
        GameObject parent;
        void Start()
        {
            Hero = Resources.Load<GameObject>("Prefabs/Hero");

            parent = GameObject.Find("Parent");
            Vector3 position = Vector3.zero;
            for (int i = 0; i < 50; i++)
            {
                float x = Random.Range(-20, 20);
                float y = Random.Range(0, 40);
                float z = Random.Range(0, 40);
                position = new Vector3(x, y, z);
                // GameObject gameObject = Instantiate(Hero, position, Quaternion.identity);
                GameObject gameObject = Instantiate(Hero, position, Quaternion.identity, parent.transform);
                // gameObject.transform.SetParent(parent.transform);
            }
        }
    }
}