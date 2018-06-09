using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {

    public TableClicker tableClicker;
    public UnityEngine.UI.Text upgradeInfo;

    public string upgradeName;
    public int upgradeCost;
    public int upgradePPS;
    public float upgradeCostCoefficient; // for next upgrade cost

    private int baseUpgradeCost;
    private int upgradeCounter = 0; // how many upgrades were bought

    void Start()
    {
        baseUpgradeCost = upgradeCost;
    }

    void Update () {
        upgradeInfo.text = upgradeName + '\n' + upgradeCost + " points +" + upgradePPS + " pps";
	}

    public void BoughtUpdate()
    {
        // when we buy update subtract cost and add ppc
        if(tableClicker.points >= upgradeCost)
        {
            tableClicker.points -= upgradeCost;
            tableClicker.pointsPerClick += upgradePPS;
            upgradeCounter++;

            upgradeCost = (int) Mathf.Round(baseUpgradeCost*Mathf.Pow(upgradeCostCoefficient, upgradeCounter));
        }
    }
}