using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

namespace Lecture13
{
    public class TestTransformComponent : MonoBehaviour
    {
        public float x = 0.01f;
        public float deg = 0f;
        public float angleInc = 1f;

        // public Vector3 cubeScale = new Vector3(1, 1, 1);
        public Vector3 scaleFactor = new Vector3(0.01f, 0.01f, 0.01f);
        // Start is called before the first frame update
        void Start()
        {
            // transform.position = new Vector3(5, 0, 0);
        }

        // Update is called once per frame
        void Update()  // Game Loop
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                deg = deg + angleInc;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                deg = deg - angleInc;
            }

            if (Input.GetKey(KeyCode.KeypadPlus))
            {
                transform.localScale += scaleFactor;
            }
            else if (Input.GetKey(KeyCode.KeypadMinus))
            {
                transform.localScale -= scaleFactor;
            }
            // transform.position = transform.position + new Vector3(x, 0, 0);
            // transform.position += new Vector3(x, 0, 0);
            transform.rotation = Quaternion.Euler(new Vector3(0, deg, 0));
        }
    }
}
