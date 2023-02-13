using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZButton : MonoBehaviour
{
    public bool pressed;
    public AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerZ"))
        {
            pressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerZ"))
        {
            pressed = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerX"))
        {
            audioManager.StopAllExcept("Music");
            audioManager.Play("xBadButton");
        }
        else if (collision.CompareTag("PlayerC"))
        {
            audioManager.StopAllExcept("Music");
            audioManager.Play("cBadButton");

        }
        else if (collision.CompareTag("PlayerV"))
        {
            audioManager.StopAllExcept("Music");
            audioManager.Play("vBadButton");

        }
    }
}
