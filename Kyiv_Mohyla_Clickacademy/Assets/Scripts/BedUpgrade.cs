﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedUpgrade : MonoBehaviour {

    public TableClicker tableClicker;
    public SliderController sliderController;
    public UnityEngine.UI.Text upgradeInfo;

    public string upgradeName;
    public int upgradeCost;
    public float perClick; // sleep/hunger per CLICK
    public float upgradeCostCoefficient; // for next upgrade cost

    private int baseUpgradeCost;
    public int upgradeCounter = 0; // how many upgrades were bought

    public Color notReadyToBuy;
    public Color readyToBuy;

    void Start()
    {
        baseUpgradeCost = upgradeCost;
        perClick = sliderController.addPerClick;
    }

    void Update()
    {
        upgradeInfo.text = upgradeName + '\n' + upgradeCost + " points " + perClick + " p/c";
        if (tableClicker.points >= upgradeCost)
        {
            GetComponent<Image>().color = readyToBuy;
        }
        else
        {
            GetComponent<Image>().color = notReadyToBuy;
        }
    }

    public void BoughtUpdateBed()
    {
        // when we buy update subtract cost and add ppc
        if (tableClicker.points >= upgradeCost)
        {
            tableClicker.points -= upgradeCost;
            sliderController.addPerClick += perClick;
            perClick = sliderController.addPerClick;
            upgradeCounter++;

            // new cost
            upgradeCost = (int)Mathf.Round(baseUpgradeCost * Mathf.Pow(upgradeCostCoefficient, upgradeCounter));
        }
    }
}
