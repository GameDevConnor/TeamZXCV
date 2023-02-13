using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    Vector2 moveDirVel;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirVel = new Vector2(0f, 0f);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirVel * Time.fixedDeltaTime);
    }
}
