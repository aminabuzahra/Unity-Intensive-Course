
using UnityEngine;

namespace Lecture23
{
    public class AnotherClass : MonoBehaviour
    {

        void OnEnable()
        {
            ActionExample.functionM += doSomething2;
        }

        void Start()
        {
            // ActionExample.functionM?.Invoke();
        }

        public void doSomething2()
        {
            Debug.Log("Subhi");
        }

        void OnDisable()
        {
            ActionExample.functionM -= doSomething2;
        }
    }
}