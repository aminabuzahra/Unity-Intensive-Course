using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lecture31
{
    [ExecuteInEditMode]
    public class ChangeColor : MonoBehaviour
    {

        [SerializeField]
        Color color = Color.red;

        public Material material;
        void Start()
        {

        }

        void LateUpdate()
        {
            GetComponent<Renderer>().sharedMaterial.color = color;
        }

        [ContextMenu("Blue")]
        public void SetColorBlue()
        {
            color = Color.blue;
            // GetComponent<Renderer>().sharedMaterial.color = Color.blue;
        }
        [ContextMenu("Yellow")]
        public void SetColorYellow()
        {
            color = Color.yellow;
            // GetComponent<Renderer>().sharedMaterial.color = Color.blue;
        }
    }
}