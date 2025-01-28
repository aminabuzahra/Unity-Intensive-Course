using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Lecture20
{
    public class OnOff : MonoBehaviour
    {
        public GameObject capsule;

        float counter = 0;

        // public ManyThoughts capsule2;

        void Start()
        {
            capsule = GameObject.Find("Capsule");
            // capsule = GameObject.FindGameObjectWithTag("Abu Lutfi");
            // capsule2 = GameObject.FindObjectOfType<ManyThoughts>();
        }

        void Update()
        {
            if (capsule != null)
            {
                counter = Mathf.Floor(Time.time);
                if (counter % 2f == 0) //  
                {
                    capsule.SetActive(true);
                }
                else
                {
                    capsule.SetActive(false);
                }

                if (Time.time > 10)
                {
                    Destroy(capsule);
                }
                // Debug.Log(counter);
            }

        }
    }
}
