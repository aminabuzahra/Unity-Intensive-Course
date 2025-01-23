using System.Collections;
using System.Collections.Generic;
using Lecture15;
using UnityEngine;


namespace Lecture31
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Rigidbody))]
    public class UnityAttributes : MonoBehaviour
    {
        [SerializeField]
        int a = 10;

        [HideInInspector]
        public float Subhi = 5.5f;

        [SerializeField]
        [Range(0, 100)]
        int health = 100;

        [Header("Player Attributes:")]
        public int a1 = 10;
        public int a2 = 10;
        public int a3 = 10;
        public int a4 = 10;
        [Space]
        public int a5 = 10;
        public int a6 = 10;
        public int a7 = 10;

        void Start()
        {

        }
    }
}