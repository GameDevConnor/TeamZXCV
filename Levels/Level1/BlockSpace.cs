using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpace : MonoBehaviour
{
    public GameObject diamond;
    // Start is called before the first frame update
    void Start()
    {
        diamond.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("TealBlock"))
        {
            diamond.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("TealBlock"))
        {
            diamond.SetActive(false);
        }
    }

}
