using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture12
{
    public class UnderstandingMonoBehavior : MonoBehaviour
    {
        public LayerMask groundLayer;

        // void Awake()
        // { 
        //     Debug.Log("I am Mr. Awake()");
        // }

        // int counter = 0;

        void Start()
        {


            Vector3 pos = new Vector3(1f, 1f, 1f);
            Vector3 rot = new Vector3(45, 0, 0);
            Vector3 scal = new Vector3(2, 1, 1);
            // Debug.Log(pos);
            // Debug.Log(rot);
            // Debug.Log(scal);

            // Debug.Log(Vector3.zero);
            // Debug.Log(Vector3.one);

            // Debug.Log(Vector3.up);
            // Debug.Log(Vector3.down);
            // Debug.Log(Vector3.right);
            // Debug.Log(Vector3.left);
            // Debug.Log(Vector3.forward);
            // Debug.Log(Vector3.back);
        }

        void Update()
        {
            // if (Input.GetKey(KeyCode.Space))
            // {
            //     Debug.Log("Space Pressed!");
            // }
            // if (Input.GetKeyDown(KeyCode.Space))
            // {
            //     Debug.Log("Space Down!");
            // }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Debug.Log("Space Up!");
            }

            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                Debug.Log("Arrow Up!");
            }

            // Debug.Log(Input.mousePosition);

            // float axis = Input.GetAxis("Horizontal");  // -1 to 0 to 1
            float axisX = Input.GetAxisRaw("Horizontal");  // -1 to 0 to 1
            float axisY = Input.GetAxis("Vertical");  // -1 to 0 to 1
                                                      // float mouseWhell = Input.GetAxis("Mouse ScrollWheel");
            Debug.Log(axisX);
            Debug.Log(axisY);
            // Debug.Log(mouseWhell);

            // Debug.Log(KeyCode.Space);

            // Debug.Log(counter++);

            // void LateUpdate()
            // {

            // }

            // void FixedUpdate()  // 0.02 seconds 
            // {
            // }

            // void OnEnable()
            // {
            //     Debug.Log("On Enable");
            // }

            // void OnDisable()
            // {
            //     Debug.Log("On Disable");
            // }
        }
    }
}