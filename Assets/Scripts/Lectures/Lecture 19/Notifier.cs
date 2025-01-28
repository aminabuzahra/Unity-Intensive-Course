using System.Collections;
using System.Collections.Generic;
using Lecture19;
using UnityEngine;

namespace Lecture19
{
    public class Notifier : MonoBehaviour
    {
        public Notify notify;
        void Start()
        {
            notify?.Invoke("Hello form Ghawwar");
        }
    }
}