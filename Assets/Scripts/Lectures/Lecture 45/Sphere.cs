using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture45
{
    public class Sphere : MonoBehaviour
    {
        Material material;
        void Start()
        {
            material = GetComponent<Renderer>().material;
        }

        void OnCollisionEnter(Collision collision)
        // void OnTriggerEnter(Collider other)
        {
            // if (collision.gameObject.name == "Enemy")
            // {
            if (collision.gameObject.CompareTag("Enemy")) // Do not use collision.gameObject.tag = "Enemy" Not Performant
            {
                // material.color = Color.green;

                collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 100, ForceMode.Impulse);

                // Destroy(collision.gameObject, 3f);
                // collision.gameObject.SetActive(false);
                // collision.gameObject.GetComponent<Renderer>().enabled = false;
            }
        }

        void OnCollisionStay(Collision collision)
        {
            // material.color = Color.red;
        }
        void OnCollisionExit(Collision collision)
        {
            // material.color = Color.black;
        }
    }
}