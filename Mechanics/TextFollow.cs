using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFollow : MonoBehaviour
{

    public Transform character;
    public float offsetX;
    public float offsetY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(character.position);
        transform.position = new Vector3(pos.x + offsetX, pos.y + offsetY, pos.z);
    }
}
