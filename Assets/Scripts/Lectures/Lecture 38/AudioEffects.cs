using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture38
{
    public class AudioEffects : MonoBehaviour
    {
        AudioSource audioEffectsAudioSource;
        public AudioClip duckClip;
        void Start()
        {
            audioEffectsAudioSource = GetComponent<AudioSource>();
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.D))
            {
                audioEffectsAudioSource.PlayOneShot(duckClip);
            }
        }
    }
}