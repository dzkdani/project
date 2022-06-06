using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSine : MonoBehaviour
{
    float sineCenterY;
    public float amplitude = 2f;
    public float frequency = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        sineCenterY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        Vector2 pos = transform.position;

        float sine = Mathf.Sin(pos.x * frequency) * amplitude;
        pos.y = sineCenterY + sine;

        transform.position = pos;
    }
}
