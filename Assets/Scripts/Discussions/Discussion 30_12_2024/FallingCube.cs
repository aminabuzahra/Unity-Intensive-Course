using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class FallingCube : MonoBehaviour
{
    Transform floor;
    float fallingSpeed = 5.0f;

    float distanceY = 0;

    float t = 1f;

    void Start()
    {
        floor = GameObject.Find("Floor").transform;
        print(floor.name);

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > floor.position.y)
            {
                transform.position = new Vector3(transform.position.x,
                                                 transform.position.y - Time.deltaTime * fallingSpeed,
                                                 transform.position.z);

                if ((transform.position.y) < (floor.position.y + 1))
                {
                    transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
                    print(transform.localScale);
                    t -= Time.deltaTime * 5;
                }

            }
        }

    }
}
