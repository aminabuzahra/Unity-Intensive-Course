using UnityEngine;
public class RotationalLerp : MonoBehaviour
{
    public Transform[] target;  // Empty game objects (The path points)
    int index = 0;

    Vector3 Source;
    Vector3 Destination;

    float step = 0f;

    void Start()
    {
        Source = transform.position;
    }
    void Update()
    {
        step += Time.deltaTime;
        if (step >= 1.0f && index < target.Length)
        {
            index++;
            Source = target[index - 1].position;
            step = 0f;
        }
        // Vector3 newPositoin = Vector3.Lerp(transform.position, target.position, Time.time / 50);
        // transform.position = newPositoin;

        if (index < target.Length)
        {
            Destination = target[index].position;
            transform.position = Vector3.Slerp(Source, Destination, step);
        }
    }
}
