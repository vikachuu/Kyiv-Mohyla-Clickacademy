using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Main clicker class
 */
public class TableClicker : MonoBehaviour {

    public UnityEngine.UI.Text pointsDisplay;
    public UnityEngine.UI.Text pointsPerClickDisplay;
    public UnityEngine.UI.Text pointsPerSecondDisplay;

    public int points = 0;
    public int pointsPerClick = 1;
    public int pointsPerSecond = 0;

    public int timeToAddPoint = 1;

    public UpgradePPSManager[] ppsItemsArray; // array of point per SECOND upgrades

    void Start()
    {
        StartCoroutine(AutoTick());
    }

    void Update()
    {
        pointsDisplay.text = "Points: " + points;
        pointsPerClickDisplay.text = "P/C: " + pointsPerClick;
        pointsPerSecondDisplay.text = "P/S: " + pointsPerSecond;
    }

    public void Clicked()
    {
        points += pointsPerClick;
    }

    /**
     * count all PPS upgrades values
     */ 
    public int GetPointsPerSecond()
    {
        int points = 0;
        foreach(UpgradePPSManager item in ppsItemsArray)
        {
            points += item.upgradePPS * item.upgradeCounter; // counter (?)
        }
        return points;
    }

    public void AutoPointsPerSecond()
    {
        this.points += GetPointsPerSecond();
    }

    /**
     * Add value every second
     */
    IEnumerator AutoTick()
    {
        while(true)
        {
            AutoPointsPerSecond();
            yield return new WaitForSeconds(timeToAddPoint);
        }
    }
}