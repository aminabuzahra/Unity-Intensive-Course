using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour
{
    public float openBookSpeed = 20;
    float bookAngle = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.D)) // Right
        {
            bookAngle -= Time.deltaTime * openBookSpeed;
            RotateBookCover();
        }
        else if (Input.GetKey(KeyCode.A)) // Left
        {
            bookAngle += Time.deltaTime * openBookSpeed;
            RotateBookCover();
        }
    }

    private void RotateBookCover()
    {
        bookAngle = Mathf.Clamp(bookAngle, -180, 0);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, bookAngle));
        // Debug.Log(transform.rotation.eulerAngles.z);
    }
}
