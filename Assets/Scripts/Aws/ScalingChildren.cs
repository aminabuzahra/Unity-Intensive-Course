using System;
using System.Collections;
using System.Collections.Generic;
using AwsUtilites;
using UnityEngine;

public class ScalingChildren : MonoBehaviour
{
    [SerializeField]
    Transform cage;

    [SerializeField]
    Transform[] childrenOfCage;

    float t = 0;
    float y = 1;

    void Start()
    {
        cage = GameObject.Find("Cage").transform;
        childrenOfCage = cage.GetChildren();
    }

    void Update()
    {
        foreach (var child in childrenOfCage)
        {
            t += Time.deltaTime / 2;
            y = Mathf.Lerp(1, 3, t);
            child.localScale = new Vector3(1, y, 1);
        }
    }
}
