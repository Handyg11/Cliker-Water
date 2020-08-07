using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockManager : MonoBehaviour
{
    
    public GameControllerScript gcs;

    public upgradeManager um;
    
    public GameObject hidden1, hidden2, water;

    private double baseHidden, gpsHidden;
    //public float tempPrice;


    // Start is called before the first frame update
    void Start()
    {
        baseHidden = um.cost;
        gpsHidden = um.gpsCost;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void UnlockWater(){
        if(gcs.moneyAmount >= um.cost){
            SoundManager.PlaySound("upgrade");
            gcs.moneyAmount -= um.cost;
            //calculation for upgrade next
            um.gpsCost = gpsHidden + (um.waterCount * um.tickValue) + ((gcs.prestigePercent* 0.01) * gpsHidden);
            um.waterCount += 1;
            um.cost = baseHidden + (um.waterCount * um.multiplier);
            //unlocking water gameobject
            gcs.gpsAmount += um.gpsCost;
            hidden1.gameObject.SetActive(false);
            hidden2.gameObject.SetActive(true);
            water.gameObject.SetActive(true);
            Debug.Log(gcs.gpsAmount + " gpsAmount");
        }
    }
}
