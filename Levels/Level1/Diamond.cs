using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{

    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerZ") || collision.CompareTag("PlayerX") || collision.CompareTag("PlayerC") || collision.CompareTag("PlayerV"))
        {
            Destroy(gameObject);
        }
        else
        {
            transform.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        }
    }
}
