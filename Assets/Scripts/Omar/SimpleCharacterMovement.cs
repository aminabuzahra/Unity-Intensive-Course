using UnityEngine;

namespace Omar
{
public class SimpleCharacterMovement : MonoBehaviour
{
    public Vector3 max = new Vector3(4.5f, 0f, 4.5f);
    float xPos = 0;
    float zPos = 0;
    public float speed = 10;


    void Update()
    {
        xPos += Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        zPos += Input.GetAxis("Vertical") * Time.deltaTime * speed;

        xPos = Mathf.Clamp(xPos, -max.x, max.x);
        zPos = Mathf.Clamp(zPos, -max.z, max.z);


    }
}
}