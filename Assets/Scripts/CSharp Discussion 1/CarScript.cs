using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float speed = 7f;
    // float maximumSteerAngle = 60f;

    float steerSpeed = 15;

    public Transform wheelFrontRight;
    public Transform wheelFrontLeft;
    public Transform wheelRearRight;
    public Transform wheelRearLeft;

    public float wheelSpeed = 360f;

    void Start()
    {

    }

    void Update()
    {
        moveCarForwardBackward();
        rotateWheels();
        steerWheels();
    }

    void moveCarForwardBackward()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= Vector3.forward * speed * Time.deltaTime;
        }
    }

    void rotateWheels()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            wheelFrontRight.Rotate(new Vector3(0, -Time.deltaTime * wheelSpeed, 0), Space.Self);
            wheelFrontLeft.Rotate(new Vector3(0, -Time.deltaTime * wheelSpeed, 0), Space.Self);
            wheelRearRight.Rotate(new Vector3(0, -Time.deltaTime * wheelSpeed, 0), Space.Self);
            wheelRearLeft.Rotate(new Vector3(0, -Time.deltaTime * wheelSpeed, 0), Space.Self);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            wheelFrontRight.Rotate(new Vector3(0, Time.deltaTime * wheelSpeed, 0), Space.Self);
            wheelFrontLeft.Rotate(new Vector3(0, Time.deltaTime * wheelSpeed, 0), Space.Self);
            wheelRearRight.Rotate(new Vector3(0, Time.deltaTime * wheelSpeed, 0), Space.Self);
            wheelRearLeft.Rotate(new Vector3(0, Time.deltaTime * wheelSpeed, 0), Space.Self);
        }
    }

    void steerWheels()
    {
        float currentAngleY = wheelFrontRight.localEulerAngles.y;
        Debug.Log(currentAngleY);

        if (currentAngleY >= 300f || currentAngleY <= 60f)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                wheelFrontRight.localEulerAngles += new Vector3(0f, Time.deltaTime * steerSpeed, 0f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                wheelFrontRight.localEulerAngles -= new Vector3(0f, Time.deltaTime * steerSpeed, 0f);
            }
        }
    }
}
