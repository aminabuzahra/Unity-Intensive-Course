using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Lecture34
{
    public class FinalRBCharacterController : MonoBehaviour
    {
        Rigidbody rigidbody;

        float xInput = 0;
        float yInput = 0;
        bool jump = false;
        bool allowJump = true;
        RaycastHit raycastHit;

        [SerializeField]
        LayerMask layerMask;
        [SerializeField]
        float rayLength = 1f;
        [SerializeField]
        float rayLengthAddition = 0.1f;
        [SerializeField]
        float gravityAcceleration = 30;
        [SerializeField]
        float MaxMoveSpeed = 20f;
        [SerializeField]
        float jumpForce = 30;
        [SerializeField]
        float Sensetivity = 70f;
        [SerializeField]
        float dragging = 2;

        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
            Physics.gravity = new Vector3(0, -gravityAcceleration, 0);
        }

        void Update()
        {
            xInput = Input.GetAxisRaw("Horizontal");
            yInput = Input.GetAxisRaw("Vertical");

            jump = Input.GetKey(KeyCode.Space);

            allowJump = Physics.Raycast(transform.position, Vector3.down, out raycastHit, rayLength + rayLengthAddition, layerMask);
            Debug.Log(allowJump);

            // Debug.DrawRay(transform.position, Vector3.down * (rayLength + rayLengthAddition), Color.cyan);
        }

        void FixedUpdate()
        {
            Vector3 moveDirection = new Vector3(xInput, 0, yInput).normalized * Sensetivity;
            rigidbody.AddForce(moveDirection);

            rigidbody.drag = dragging;

            rigidbody.velocity = Vector3.ClampMagnitude(rigidbody.velocity, MaxMoveSpeed);

            if (jump && allowJump)
            {
                rigidbody.velocity = new Vector3(rigidbody.velocity.x, 0, rigidbody.velocity.z);
                rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }

        void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawRay(transform.position, Vector3.down * (rayLength + rayLengthAddition));
        }
    }
}
