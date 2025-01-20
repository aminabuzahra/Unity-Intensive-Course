using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerScript : MonoBehaviour
{
    public OtherScript otherScript;
    void Start()
    {
        otherScript = FindObjectOfType<OtherScript>();
        Debug.Log(otherScript.name);
    }
}
