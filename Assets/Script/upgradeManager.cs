using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradeManager : MonoBehaviour
{
    public GameControllerScript gcs;
    public double cost, gpsCost;
    private double basePrice, baseGPS;
    public double tickValue; //gps
    public double waterCount, multiplier;
    public Text itemGPS, itemAmount, itemCost;
    void Start()
    {
       basePrice = cost;
       baseGPS = gpsCost;
    }

    void Update()
    {
        itemGPS.text =  "GPS : " + gpsCost.ToString("F2");
        itemAmount.text = "Ammount : " + waterCount.ToString(); 
        itemCost.text = "Cost : " + cost.ToString("F2");
    }

    public void BuyWater(){
        if(gcs.moneyAmount >= cost){
            SoundManager.PlaySound("upgrade");
            gcs.moneyAmount -= cost;
            baseGPS = gpsCost;
            basePrice = cost;
            gpsCost = baseGPS + (waterCount * tickValue) + ((gcs.prestigePercent* 0.01) * baseGPS);
            waterCount += 1;
            cost = basePrice + (waterCount * multiplier);
            
            //storing to total gps
            gcs.gpsAmount += gpsCost;
        }
        
    }
}
