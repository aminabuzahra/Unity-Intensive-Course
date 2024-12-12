using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    float bookRotationSensitivity = 2000.0f;
    float zAngle = 0.0f;

    void Update()
    {
        // Debug.Log("Horizontal: " + Input.GetAxis("Horizontal"));  // Arrow Left, A ==> -1 | Arrow Right, D ==> 1 | none == > 0
        // Debug.Log("Vertical: " + Input.GetAxis("Vertical"));    // Arrow Up, W ==> 1 | Arrow Down, S ==> -1 | none ==> 0

        // Debug.Log("Mouse X: " + Input.GetAxis("Mouse X"));
        // Debug.Log("Mouse Y: " + Input.GetAxis("Mouse Y"));

        // Debug.Log("MouseButton(0): " + Input.GetMouseButton(0)); // True ==> Left button pressed
        // Debug.Log("MouseButton(1): " + Input.GetMouseButton(1)); // True ==> Right button pressed
        // Debug.Log("MouseButton(2): " + Input.GetMouseButton(2)); // True ==> Middle button pressed

        if (Input.GetMouseButton(0))
        {
            // transform.Rotate(Vector3.back * Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime, Space.Self); // // Increment the current angle around local z axis by the argument
            zAngle -= Input.GetAxis("Mouse X") * bookRotationSensitivity * Time.deltaTime;
            zAngle = Mathf.Clamp(zAngle, -180, 0);
            transform.rotation = Quaternion.Euler(0, 0, zAngle);
        }
    }
}
