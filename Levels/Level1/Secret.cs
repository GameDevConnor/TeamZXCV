using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret : MonoBehaviour
{
    public ZButton zButton;
    public XButton xButton;
    public CButton cButton;
    public VButton vButton;
    public GameObject nSliced;
    // Start is called before the first frame update
    void Start()
    {
        nSliced.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (zButton.pressed && xButton.pressed && cButton.pressed && vButton.pressed)
        {
            nSliced.SetActive(true);
        }
    }
}
