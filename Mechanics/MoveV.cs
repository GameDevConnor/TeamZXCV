using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveV : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    private Vector2 moveDirVel;
    public CharacterSwitch charSwitch;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        charSwitch = FindObjectOfType<CharacterSwitch>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDir = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (charSwitch.v == true)
        {
            moveDirVel = moveDir.normalized * speed;
            transform.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
        else
        {
            moveDirVel = new Vector2(0f, 0f);
            transform.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveDirVel * Time.fixedDeltaTime);
    }
}
