using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftToRight : MonoBehaviour
{
    float spd = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        Vector2 pos = transform.position;
        
        pos.x += spd * Time.fixedDeltaTime;

        if (pos.x > 4)
        {
            Destroy(gameObject);
        }

        transform.position = pos;
    }
}
