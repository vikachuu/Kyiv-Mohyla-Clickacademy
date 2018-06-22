using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
 * Common class for upgrades which add points per SECOND
 */
public class UpgradePPSManager : MonoBehaviour {

    public TableClicker tableClicker;
    public UnityEngine.UI.Text upgradeInfo;

    public string upgradeName;
    public int upgradeCost;
    public int upgradePPS; // points per SECOND
    public float upgradeCostCoefficient; // for next upgrade cost

    private int baseUpgradeCost;
    public int upgradeCounter = 0; // how many upgrades were bought

    public Color notReadyToBuy;
    public Color readyToBuy;

    void Start()
    {
        baseUpgradeCost = upgradeCost;
    }

    void Update()
    {
        upgradeInfo.text = upgradeName + '\n' + upgradeCost + " points +" + upgradePPS + " p/s";
        if (tableClicker.points >= upgradeCost)
        {
            GetComponent<Image>().color = readyToBuy;
        }
        else
        {
            GetComponent<Image>().color = notReadyToBuy;
        }
    }

    public void BoughtUpdatePPS()
    {
        // when we buy upgrade subtract cost and add pps
        if (tableClicker.points >= upgradeCost)
        {
            tableClicker.points -= upgradeCost;
            tableClicker.pointsPerSecond += upgradePPS;

            upgradeCounter++;

            // new cost
            upgradeCost = (int)Mathf.Round(baseUpgradeCost * Mathf.Pow(upgradeCostCoefficient, upgradeCounter));
        }
    }
}