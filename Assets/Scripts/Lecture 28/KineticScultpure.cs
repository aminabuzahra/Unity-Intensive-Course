using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture28
{
    public class KineticScultpure : MonoBehaviour
    {
        float angleRange = 45;
        void Start()
        {
            Transform parent = GameObject.Find("Boxes").transform;
            float delayTime = 0;
            foreach (Transform child in parent)
            {
                StartCoroutine(RotateSomething(child, delayTime));
                delayTime += 0.03f;
            }
        }

        IEnumerator RotateSomething(Transform something, float delay)
        {
            float startTime = Time.time + delay;
            float elapsedTime = 0;
            while (true)
            {
                elapsedTime = Time.time - startTime;
                something.rotation = Quaternion.Euler(0, Mathf.Sin((elapsedTime) * 6) * angleRange, 0);
                yield return null;
            }
        }
    }
}