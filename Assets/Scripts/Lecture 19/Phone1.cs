using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture19
{
    public class Phone1 : MonoBehaviour
    {
        string receivedMessage;
        public Notifier notifier;

        void Awake()
        {
            notifier.notify += Message2;
        }

        void Update()
        {
            Debug.Log(receivedMessage);
        }

        public void Message2(string msg)
        {
            receivedMessage = msg;
        }
    }
}
