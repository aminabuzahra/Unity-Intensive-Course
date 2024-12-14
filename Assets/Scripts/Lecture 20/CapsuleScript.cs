using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    // Start is called before the first frame update

    void OnEnable()
    {
        Debug.Log("Dawa");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDisable()
    {
        Debug.Log("Tafa");
    }

    void OnDestroy()
    {
        Debug.Log("I am dead !!!!!!!!!");
    }
}
