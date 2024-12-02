using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public float speed = 7f;
    float maximumSteerAngle = 60f;

    public float steerSpeed = 30;

    public Transform wheelFrontRight;
    public Transform wheelFrontLeft;
    public Transform wheelRearRight;
    public Transform wheelRearLeft;

    Vector3 forward = Vector3.forward;

    public float wheelSpeed = 360f;

    float angleOfWheels = 0;

    void Update()
    {
        moveCarForwardBackward();
        rotateWheels();
        steerWheels();
        steerCar();
    }

    void moveCarForwardBackward()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= forward * speed * Time.deltaTime;
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            angleOfWheels += Time.deltaTime * steerSpeed;
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            angleOfWheels -= Time.deltaTime * steerSpeed;
        }
        else
        {
            angleOfWheels = Mathf.Lerp(angleOfWheels, 0, Time.deltaTime * steerSpeed * 0.75f);
        }

        angleOfWheels = Mathf.Clamp(angleOfWheels, -maximumSteerAngle, maximumSteerAngle);

        wheelFrontRight.localEulerAngles = new Vector3(0f, angleOfWheels, 90f);
        wheelFrontLeft.localEulerAngles = new Vector3(0f, angleOfWheels, 90f);
    }

    void steerCar()
    {
        // forward = Quaternion.Euler(0, 1, 0) * forward;
    }
}
