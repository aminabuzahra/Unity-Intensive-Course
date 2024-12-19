using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfacesExample : MonoBehaviour, IDamagable
{
    void Start()
    {
        if (this is IDamagable)
        {
            Debug.Log("I am Damagable !");
        }
    }
}

public interface IDamagable
{
}

// coroutines : Juice, UI Animation, Tween, Synchroniztion 
// yield return 
// IEnumerable, IEnumerator, IComparable
