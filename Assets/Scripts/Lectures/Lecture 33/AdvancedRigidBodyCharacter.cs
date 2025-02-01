using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture33
{
    public class AdvancedRigidBodyCharacter : MonoBehaviour
    {
        // [SerializeField]
        LayerMask layerMask; // = "Sharshabeel"

        void Start()
        {
            layerMask = LayerMask.GetMask("Sharshabeel", "Azoul");
            RaycastHit[] raycastHits;

            // RaycastHit : Collision point, Collider, *normal*, distance
            // Ray: origin, distance, ...
            // Physics.Raycast()
            // LayerMask (Layers)
            // RaycastHit
            // LayerMask

            // Ray shuaa = new Ray(transform.position, Vector3.left);
            // RaycastHit hitInfo;

            // if (Physics.Raycast(transform.position, Vector3.left, out hitInfo, 6f, layerMask))
            // {
            //     Debug.Log("Shuaa hit something");
            //     Debug.Log(hitInfo.collider.name);
            // }

            // raycastHits = Physics.RaycastAll(transform.position, Vector3.left, 6f, layerMask);
            // foreach (var hit in raycastHits)
            // {
            //     Debug.Log(hit.collider.name);
            // }



            // Rigidbody rb = GetComponent<Rigidbody>();
            // rb.useGravity = false;

            // Physics.gravity = new Vector3(-9.81f, 0, 0);

            // Physics.IgnoreCollision(transform.GetChild(0).GetComponent<Collider>(), GameObject.Find("Floor").GetComponent<Collider>());

        }

        void Update()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, 6);
            if (Input.GetKeyUp(KeyCode.Space))
            {
                foreach (var collider in colliders)
                {
                    Debug.Log(collider.name);
                    Rigidbody rigidbody = collider.GetComponent<Rigidbody>();
                    if (rigidbody != null)
                    {
                        rigidbody.AddExplosionForce(100, transform.position, 5f, 1f, ForceMode.Impulse);
                    }
                }
            }
        }
    }
}
