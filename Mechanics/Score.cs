using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int zScore;
    public int xScore;
    public int cScore;
    public int vScore;
    public int total;
    public TextMeshProUGUI scores;
    // Start is called before the first frame update
    void Start()
    {
        zScore = 0;
        xScore = 0;
        cScore = 0;
        vScore = 0;
        total = 0;
    }

    // Update is called once per frame
    void Update()
    {
        total = zScore + xScore + cScore + vScore;

        scores.text = "Z Score: " + zScore + "\nX Score: " + xScore + "\nC Score: " + cScore + "\nV Score: " + vScore + "\nTotal: " + total;
    }
}
