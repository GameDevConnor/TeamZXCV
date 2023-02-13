using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterSwitch : MonoBehaviour
{

    public bool z;
    public bool x;
    public bool c;
    public bool v;

    public TextMeshProUGUI selection;

    public AudioManager audioManager;

    public float[] distances;

    public GameObject zPlayer;
    public GameObject xPlayer;
    public GameObject cPlayer;
    public GameObject vPlayer;

    public Camera camera;

    public float zoom = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectZ();
        audioManager = FindObjectOfType<AudioManager>();
        distances = new float[4];
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            audioManager.StopAllExcept("Music");
            selectZ();
            audioManager.Play("zSelect");
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            audioManager.StopAllExcept("Music");
            selectX();
            audioManager.Play("xSelect");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            audioManager.StopAllExcept("Music");
            selectC();
            audioManager.Play("cSelect");
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            audioManager.StopAllExcept("Music");
            selectV();
            audioManager.Play("vSelect");
        }

        selection.text = "Selection: " + selectedPlayer();
    }


    void selectZ()
    {
        z = true;
        x = false;
        c = false;
        v = false;
    }
    void selectX()
    {
        z = false;
        x = true;
        c = false;
        v = false;
    }
    void selectC()
    {
        z = false;
        x = false;
        c = true;
        v = false;
    }
    void selectV()
    {
        z = false;
        x = false;
        c = false;
        v = true;
    }

    public string selectedPlayer()
    {
        if (z == true)
            return "Green";
        else if (x == true)
            return "Pink";
        else if (c == true)
            return "White";
        else if (v == true)
            return "Red";
        else
            return "None";
    }

    float biggestDistance(float[] distances)
    {
        float biggest = 0;
        for (int i = 0; i <= distances.Length - 1; i++)
        {
            if (distances[i] > biggest)
            {
                biggest = distances[i];
            }
        }
        return biggest;
    }

    void FixedUpdate()
    {
        distances[0] = (transform.position - zPlayer.transform.position).magnitude;
        distances[1] = (transform.position - xPlayer.transform.position).magnitude;
        distances[2] = (transform.position - cPlayer.transform.position).magnitude;
        distances[3] = (transform.position - vPlayer.transform.position).magnitude;
        camera.orthographicSize = biggestDistance(distances) + zoom;
    }

}
