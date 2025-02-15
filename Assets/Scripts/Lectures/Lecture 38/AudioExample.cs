using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture38
{
    public class AudioExample : MonoBehaviour
    {
        AudioSource backgroundMusicAudioSource;

        public AudioClip backgroundMusicClip;
        public AudioClip[] clips;

        float vInc = 5;
        float pInc = 0.5f;

        Vector3 zPosition;

        void Start()
        {
            backgroundMusicAudioSource = GetComponent<AudioSource>();
            backgroundMusicAudioSource.clip = backgroundMusicClip;

            backgroundMusicAudioSource.minDistance = 1f; // Maximum Volume
            backgroundMusicAudioSource.maxDistance = 10f; // Minumum Volume
            backgroundMusicAudioSource.spatialBlend = 1f;
            backgroundMusicAudioSource.rolloffMode = AudioRolloffMode.Linear;
            backgroundMusicAudioSource.dopplerLevel = 2f;

            zPosition = transform.position;
        }

        void Update()
        {
            if (Input.GetKeyUp(KeyCode.D))
            {
                backgroundMusicAudioSource.PlayOneShot(clips[Random.Range(0, clips.Length)]);
            }

            if (Input.GetKeyUp(KeyCode.S))
            {
                backgroundMusicAudioSource.Stop();
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                backgroundMusicAudioSource.Play();
            }

            if (Input.GetKeyUp(KeyCode.P))
            {
                backgroundMusicAudioSource.Pause();
            }

            if (Input.GetKeyUp(KeyCode.U))
            {
                backgroundMusicAudioSource.UnPause();
            }

            if (Input.GetKeyUp(KeyCode.KeypadPlus))
            {
                float vIncrement = Time.deltaTime * vInc;
                if ((backgroundMusicAudioSource.volume + vIncrement) < 1)
                    backgroundMusicAudioSource.volume += vIncrement;
            }

            if (Input.GetKeyUp(KeyCode.KeypadMinus))
            {
                float vIncrement = Time.deltaTime * vInc;
                if ((backgroundMusicAudioSource.volume - vIncrement) > 0)
                    backgroundMusicAudioSource.volume -= vIncrement;
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                float vIncrement = Time.deltaTime * pInc;
                if ((backgroundMusicAudioSource.pitch + vIncrement) < 3)
                    backgroundMusicAudioSource.pitch += vIncrement;
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                float vIncrement = Time.deltaTime * pInc;
                if ((backgroundMusicAudioSource.pitch - vIncrement) > 0.5f)
                    backgroundMusicAudioSource.pitch -= vIncrement;
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                zPosition += Vector3.forward;
                AudioSource.PlayClipAtPoint(clips[0], zPosition);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                zPosition -= Vector3.forward;
                AudioSource.PlayClipAtPoint(clips[0], zPosition);
            }

        }
    }
}
