using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture21
{
    public class ExceptionExample : MonoBehaviour
    {
        void Start()
        {
            // Excpetion: Run Time Error
            int a = 10;

            try
            {
                // open session with remote server
                // a = a / 0;
                if (a == 10)
                {
                    throw new Exception("Saka'aeh Exception :)");
                }
            }

            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }

            finally
            {
                Debug.Log("Closing Session ....");
            }

            Debug.Log("After catching the exception");

            Debug.Log(a);
        }

        // public class SException : Exception
        // {
        //     public SException(string message) : base(message)
        //     {
        //     }
        // }
    }
}