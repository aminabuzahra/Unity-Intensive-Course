using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture45
{
    public class ChangeColor : MonoBehaviour
    {
        [SerializeField]
        AudioClip[] clips;
        AudioSource audioSource;
        Renderer renderer;
        Material material;
        void Start()
        {
            renderer = GetComponent<Renderer>();
            material = renderer.material;

            audioSource = GetComponent<AudioSource>();
            // material = renderer.sharedMaterial;
        }

        void Update()
        {

        }

        void OnCollisionEnter(Collision collision)
        {
            material.color = Random.ColorHSV();
            if (!audioSource.isPlaying)
                audioSource.PlayOneShot(clips[Random.Range(0, clips.Length)], Random.Range(0.6f, 1f));
            // Debug.Log("Collision Occured");
        }

        void OnCollisionExit(Collision collision)
        {
            material.color = Color.black;

        }

    }
}