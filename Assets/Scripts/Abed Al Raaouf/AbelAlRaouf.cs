using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbelAlRaouf : MonoBehaviour
{

    [SerializeField]
    float[] driver = new float[3] { 0, 0, 0 };

    [SerializeField]
    int index = 0;

    float speed = 10f;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (index > 0)
            {
                index--;
            }
        }

        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (index < driver.Length - 1)
            {
                index++;
            }
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (driver[index] <= 1)
            {
                AR(index, ref driver, Time.deltaTime * speed);
                // AR(index, ref driver, 0.01f);
            }
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (driver[index] >= 0)
            {
                driver[index] -= Time.deltaTime * speed;
                driver[index] = Mathf.Clamp(driver[index], 0, 1);
            }
        }
    }

    public static void AR(int index, ref float[] driver, float incrementValue)
    {
        int previous = index - 1;
        if (previous >= 0)
        {
            driver[previous] -= incrementValue;
            driver[previous] = Mathf.Clamp(driver[previous], 0, 1);
        }

        driver[index] += incrementValue;
        driver[index] = Mathf.Clamp(driver[index], 0, 1);
    }
}
