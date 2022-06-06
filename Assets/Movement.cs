using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Gun[] guns;

    float spd = 5f;

    bool moveUp;
    bool moveDown;
    bool moveLeft;
    bool moveRight;

    bool shoot;

    // Start is called before the first frame update
    void Start()
    {
        guns = transform.GetComponentsInChildren<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        moveUp = (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W));
        moveLeft = (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A));
        moveDown = (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S));
        moveRight = (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D));

        shoot = (Input.GetKeyDown(KeyCode.Space));
        if (shoot)
        {
            shoot = false;
            foreach (Gun gun in guns)
            {
                gun.Shoot();
            }
        }
    }

    private void FixedUpdate() {
        Vector2 pos = transform.position;

        float moveAmount = spd * Time.fixedDeltaTime;
        Vector2 move = Vector2.zero;

        if (moveUp)
        {
            move.y += moveAmount;
        }

        if (moveDown)
        {
            move.y -= moveAmount;
        }

        if (moveLeft)
        {
            move.x -= moveAmount;
        }

        if (moveRight)
        {
            move.x += moveAmount;
        }

        float moveMagnitude = Mathf.Sqrt(move.x * move.x + move.y * move.y);
        if (moveMagnitude > moveAmount)
        {
            float ratio = moveAmount / moveMagnitude;
            move *= ratio;
        }

        pos += move;

        transform.position = pos;
    }
}
