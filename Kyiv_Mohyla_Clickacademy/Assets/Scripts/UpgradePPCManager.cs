using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Common class for upgrades which add points per CLICK
 */
public class UpgradePPCManager : MonoBehaviour {

    public TableClicker tableClicker;
    public UnityEngine.UI.Text upgradeInfo;

    public string upgradeName;
    public int upgradeCost;
    public int upgradePPC; // points per CLICK
    public float upgradeCostCoefficient; // for next upgrade cost

    private int baseUpgradeCost;
    public int upgradeCounter = 0; // how many upgrades were bought

    void Start()
    {
        baseUpgradeCost = upgradeCost;
    }

    void Update () {
        upgradeInfo.text = upgradeName + '\n' + upgradeCost + " points +" + upgradePPC + " p/c";
	}

    public void BoughtUpdatePPC()
    {
        // when we buy update subtract cost and add ppc
        if(tableClicker.points >= upgradeCost)
        {
            tableClicker.points -= upgradeCost;
            tableClicker.pointsPerClick += upgradePPC;
            upgradeCounter++;

            // new cost
            upgradeCost = (int) Mathf.Round(baseUpgradeCost*Mathf.Pow(upgradeCostCoefficient, upgradeCounter));
        }
    }
}