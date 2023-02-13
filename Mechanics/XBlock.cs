using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBlock : MonoBehaviour
{
    Vector2 moveDirVel;
    Rigidbody2D rb;
    public AudioManager audioManager;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioManager = FindObjectOfType<AudioManager>();
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("PlayerX"))
        {
            collision.otherCollider.attachedRigidbody.isKinematic = false;
            //Debug.Log(collision.collider.tag);

        }
        else
        {
            collision.otherCollider.attachedRigidbody.isKinematic = true;
        }

        if (collision.collider.CompareTag("PlayerV"))
        {
            audioManager.StopAllExcept("Music");
            audioManager.Play("vBadBlock");
        }
        else if (collision.collider.CompareTag("PlayerC"))
        {
            audioManager.StopAllExcept("Music");
            audioManager.Play("cBadBlock");

        }
        else if (collision.collider.CompareTag("PlayerZ"))
        {
            audioManager.StopAllExcept("Music");
            audioManager.Play("zBadBlock");

        }
        else if (collision.collider.CompareTag("PlayerX"))
        {
            audioManager.StopAllExcept("Music");
            audioManager.Play("xGoodBlock");
        }
    }
}
