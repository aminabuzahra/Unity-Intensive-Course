using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class BackFlipping : MonoBehaviour
{
    Rigidbody rb;
    bool jump = false;
    bool isFlipComplete = true;
    Color color = Color.green;
    int numOfJumps = 0;
    Transform ground;

    float flipAngle = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        ground = GameObject.Find("Floor").transform;

        // Vector3 v = new Vector3(0, 5, 0);
        // Debug.Log(v.normalized); // لطباعة الاتجاه
        // Debug.Log(v.magnitude); // لطباعة القيمة
    }

    void Update()
    {
        CheckInputForJump();
        ResetJumpsWhenGrounded();
    }

    void FixedUpdate()
    {
        JumpAndBackFlip();
    }

    private void CheckInputForJump()
    {
        if (Input.GetKeyUp(KeyCode.Space) && numOfJumps < 2)
        {
            jump = true;
            numOfJumps++;
        }
    }

    private void ResetJumpsWhenGrounded()
    {
        float distance = Vector3.Distance(transform.position, ground.position);
        if (distance < 0.01f)
        {
            numOfJumps = 0;
        }
    }



    private void JumpAndBackFlip()
    {
        if (jump)
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            isFlipComplete = false;
            rb.AddForce(new Vector3(0, 15, 0), ForceMode.Impulse); // قوة خطية
            // rb.AddTorque(Vector3.left * 2, ForceMode.Impulse);
            // rb.angularVelocity = Vector3.zero;
            jump = false;
        }

        if (!isFlipComplete)
        {
            flipAngle -= Time.fixedDeltaTime * 280;
            flipAngle = Mathf.Clamp(flipAngle, -359, 0);
            rb.MoveRotation(Quaternion.Euler(flipAngle, 0, 0));
        }

        if (flipAngle == -359)
        {
            isFlipComplete = true;
            flipAngle = 0;
            rb.freezeRotation = true;
        }
    }
}
