using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableClicker : MonoBehaviour {

    public UnityEngine.UI.Text pointsDisplay;
    public UnityEngine.UI.Text pointsPerClickDisplay;
    public int points = 0;
    public int pointsPerClick = 1;

    void Update()
    {
        pointsDisplay.text = "Points: " + points;
        pointsPerClickDisplay.text = "P/C: " + pointsPerClick;
    }

    public void Clicked()
    {
        points += pointsPerClick;
    }

}