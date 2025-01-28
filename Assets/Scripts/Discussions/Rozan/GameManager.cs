using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Rozan
{
    public class GameManager : MonoBehaviour
    {
        public GameObject[] cubes;

        void Start()
        {
        }

        void Update()
        {
            float displacement = 1;
            foreach (GameObject cube in cubes)
            {
                displacement += 0.1f;
                float yNew = Mathf.Sin(Time.time * displacement);
                cube.transform.rotation = Quaternion.Euler(new Vector3(0, yNew * 45f, 0));
            }
        }

    }
}
