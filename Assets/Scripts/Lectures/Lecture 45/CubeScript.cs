using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture45
{
    public class CubeScript : MonoBehaviour
    {
        AudioSource audioSource;

        void Start()
        {
            audioSource = GetComponent<AudioSource>();
        }

        void Update()
        {

        }
        void OnBecameInvisible()
        {
            audioSource.Play();
        }
    }
}