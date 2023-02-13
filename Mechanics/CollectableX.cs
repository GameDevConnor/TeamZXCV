using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableX : MonoBehaviour
{
    public Score score;
    public AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerX"))
        {
            audioManager.StopAllExcept("Music");

            audioManager.Play("xGoodCollect");
            score.xScore++;
            Destroy(gameObject);
        }
        else
        {
            transform.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        }

        if (collision.CompareTag("PlayerZ"))
        {
            audioManager.StopAllExcept("Music");

            audioManager.Play("zBadCollect");
        }
        else if (collision.CompareTag("PlayerC"))
        {
            audioManager.StopAllExcept("Music");

            audioManager.Play("cBadCollect");

        }
        else if (collision.CompareTag("PlayerV"))
        {
            audioManager.StopAllExcept("Music");

            audioManager.Play("vBadCollect");

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.GetComponent<Renderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
}
