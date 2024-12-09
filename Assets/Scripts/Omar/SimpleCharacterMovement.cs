using UnityEngine;

namespace Omar
{
    public class SimpleCharacterMovement : MonoBehaviour
    {
        public Vector3 max = new Vector3(4.5f, 0f, 4.5f);
        float xPos = 0;
        float zPos = 0;
        public float speed = 10;
        Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            xPos += Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
            zPos += Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

            // transform.position = new Vector3(xPos, transform.position.y, zPos);
            rb.velocity = new Vector3(xPos, 0, zPos);
        }
    }
}