using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {

    public TableClicker tableClicker;
    public UnityEngine.UI.Text upgradeInfo;

    public string upgradeName;
    public int upgradeCost;
    public int upgradePPS;

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
        }
    }
}