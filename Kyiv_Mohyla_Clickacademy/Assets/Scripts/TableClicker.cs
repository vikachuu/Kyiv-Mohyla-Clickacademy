using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableClicker : MonoBehaviour {

    public UnityEngine.UI.Text pointsDisplay;
    public int points = 0;
    public int pointsPerClick = 1;

    void Update()
    {
        pointsDisplay.text = "Points: " + points;
    }

    public void Clicked()
    {
        points += pointsPerClick;
    }

}