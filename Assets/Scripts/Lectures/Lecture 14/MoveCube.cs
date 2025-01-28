
using UnityEngine;

namespace Lecture14
{
    public class MoveCube : MonoBehaviour
    {
        // public float speed = 1f;
        // private float counter = 0;
        // private float x = 0;
        // 0 - 360
        // radians

        void Start()
        {
            Debug.Log(180 * Mathf.Deg2Rad);
            Debug.Log(Mathf.Sin(180f * Mathf.Deg2Rad));
        }

        void Update()
        {
            // transform.position += new Vector3(speed * Time.deltaTime, 0, 0);  // 400 * 0.01f = 4 / s; 1 / 400 = 0.0025
            // 800 * 0.01f = 8 / s; 1 / 800 = 0.00125 
            // transform.position += new Vector3(speed * Time.smoothDeltaTime, 0, 0);
            // Debug.Log(Time.frameCount / Time.time);

            // float xNew = Mathf.Cos(Time.time * 4);  // - 1 to 1
            // float yNew = Mathf.Sin(Time.time);  // - 1 to 1
            // transform.position += new Vector3(xNew * Time.deltaTime * 4f, transform.position.y, transform.position.z);
            // transform.rotation = Quaternion.Euler(new Vector3(xNew * 60f, yNew * 45f, 0));
            // transform.localScale = new Vector3(1, 1, 1) * xNew / 2 + new Vector3(3, 3, 3);

            float xNew = Mathf.PingPong(Time.time * 10, 10) - 5;
            Debug.Log(xNew);
            transform.position = new Vector3(xNew, transform.position.y, transform.position.z);

        }
    }
}
