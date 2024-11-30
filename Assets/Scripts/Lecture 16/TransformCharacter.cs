
using UnityEngine;


public class TransformCharacter : MonoBehaviour
{
    float anglel = 0f;

    public Transform gameObject;

    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // transform.rotation = Quaternion.Euler(new Vector3(0, speed * anglel++ * Time.deltaTime, 0));
        // transform.Translate(new Vector3(1 * Time.deltaTime, 0, 0), Space.World);
        // transform.Rotate(Vector3.right, speed * Time.deltaTime, Space.Self);

        transform.LookAt(gameObject);

        if (Vector3.Distance(gameObject.position, transform.position) > 0.1f)
        {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        }
    }
}
