using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Lecture27
{
    public class Couroutines : MonoBehaviour
    {
        public float x;
        bool move = false;

        public GameObject gameObject;
        void OnEnable()
        {
            Coroutine coroutine = StartCoroutine(Loop());
            Coroutine coroutine1 = StartCoroutine(MoveObject());
            Coroutine coroutine2 = StartCoroutine(Flash());
        }

        void Start()
        {
            Debug.Log(CalculateSomething(10));
            Debug.Log(CalculateSomething(20));
        }

        IEnumerator Loop()
        {
            for (int i = 0; i < 1_000_000_000; i++)
            {
                yield return null;
            }
        }

        IEnumerator MoveObject()
        {
            while (true)
            {
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    x += Time.deltaTime * 2;
                    transform.position = new Vector3(x, 0, 0);
                }
                yield return null; // إنتقل الى الفريم الذي يلي
                                   // continue to the next frame
            }
        }

        IEnumerator Flash()
        {
            while (true)
            {
                yield return new WaitForSeconds(1); // pause for 1 second
                gameObject.SetActive(true);
                yield return new WaitForSeconds(1);
                gameObject.SetActive(false);
            }
        }

        int CalculateSomething(int value)
        {
            int a = 5;

            Func<int, int> add = b => a + b;

            return add(value);
        }
    }
}
