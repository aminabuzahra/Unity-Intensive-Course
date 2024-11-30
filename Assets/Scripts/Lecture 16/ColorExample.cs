using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorExample : MonoBehaviour
{
    // public Color color;  // RGB (Red Green Blue) - HSV

    private Color anotherColor = new Color(1f, 1f, 1f, 1f);

    public Color startColor = Color.red;
    public Color endColor = Color.blue;

    Renderer renderer;
    Material material;

    float timer = 0;

    public float speed = 10;

    void Start()
    {

        Camera.main.backgroundColor = Color.green;

        renderer = GetComponent<Renderer>();

        material = renderer.material;

        // material.color = new Color(Random.Range(0,1.0000001f), Random.Range(0,1.0000001f), Random.Range(0,1.0000001f));
        // material.color = new Color(Random.value, Random.value, Random.value);
    }

    void Update()
    {

        // endColor.a = 0.5f;

        if (timer < 1f && timer > 0)
        {
            timer += Time.deltaTime;
        }
        else if (timer > 1f)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0)
        {
            timer += Time.deltaTime;
        }

        Debug.Log(timer);

        material.color = Color.Lerp(startColor, endColor, timer);

        // float r2 = Mathf.PingPong(startColor.r, timer) + endColor.r;
        // float g2 = Mathf.PingPong(startColor.g, timer) + endColor.g;
        // float b2 = Mathf.PingPong(startColor.b, timer) + endColor.b;

        // material.color = new Color(r2, b2, g2);
    }
}
