using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSeveralObjects : MonoBehaviour
{
    public Transform[] cubes;
    public float[] speeds;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].Translate(Vector3.left * speeds[i] * Time.deltaTime);
        }
        
    }
}
