using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public UpgradePPCManager tableUpgrade;
    public UpgradePPSManager chairUpgrade;
    public BedFridgeUpgrade bedUpgrade;
    public BedFridgeUpgrade fridgeUpgrade;

    public Image wall;
    public Image floor;

    public Sprite[] walls;
    public Sprite[] floors;


    void Start()
    {

    }

    void Update()
    {
        if (tableUpgrade.upgradeCounter == 4 && chairUpgrade.upgradeCounter == 4
            && bedUpgrade.upgradeCounter == 4 && fridgeUpgrade.upgradeCounter == 4)
        {
            wall.sprite = walls[2];
            floor.sprite = floors[2];
        }
        else if (tableUpgrade.upgradeCounter == 2 && chairUpgrade.upgradeCounter == 2
           && bedUpgrade.upgradeCounter == 2 && fridgeUpgrade.upgradeCounter == 2)
        {
            wall.sprite = walls[1];
            floor.sprite = floors[1];
        }
    }
}
