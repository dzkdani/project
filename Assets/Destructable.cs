using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour
{

    bool IsDesctructable = false;
    // Start is called before the first frame update
    void Start()
    {
        IsDesctructable = false;    
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -1.5f)
        {
            IsDesctructable = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (IsDesctructable)
        {
            Bullet bullet = other.GetComponent<Bullet>();
            if (bullet != null)
            {
                Destroy(gameObject);
                Destroy(bullet.gameObject);
            }
        }
    }
}
