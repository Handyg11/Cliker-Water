using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControllerScript : MonoBehaviour
{
    public double moneyAmount = 0.0f, moneyPerClick = 1.0f, gpsAmount = 0.0f, prestigePercent = 0f;
    public static double prestigeBonus;

    public int stock;

    public Text moneyText, gpsText, stockText;

    public GameObject addMoneyTxT, prestigeBtn;

    public GameObject hidden1,hidden2,hidden3,hidden4,hidden5,hidden6,hidden7;

    public GameObject water1,water2,water3,water4,water5,water6,water7;

    public upgradeManager um1, um2, um3, um4, um5, um6, um7;

    public Transform moneyTransform;
    private Vector3 offset;

    Vector3 moneyTextPos;
    void Start()
    {
        //offset = new Vector3(-361.6f,-106.9f,0);
        reset();
        stockText.gameObject.SetActive(false);
        moneyAmount= 0;
    }

    void Update()
    {
        moneyText.text = "Total Money: " + moneyAmount.ToString("F2");
        gpsText.text = "Total GPS: " + gpsAmount.ToString("F2");
        stockText.text = "Stock: " + prestigeBonus;

        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }

    public void increaseMoneyAmount()
    {
        moneyAmount += moneyPerClick;
        GameObject newWaterTxt = Instantiate(addMoneyTxT,moneyTextPos,Quaternion.identity) as GameObject;
        newWaterTxt.transform.SetParent(GameObject.FindGameObjectWithTag("gameDisplay").transform,false);
        //moneyTextPos = moneyTransform.position + offset;
        SoundManager.PlaySound("click");
    }

    public void prestigeAmount(){
        if(moneyAmount >= 100000){
            prestigeBonus = (int)((moneyAmount-100000) *0.00001);
            moneyAmount = 0;
            gpsAmount = 0;
            stock += 1;
            prestigePercent+= prestigeBonus * 0.01;
            resetUnlock();
            reset();
            stockText.gameObject.SetActive(true);
            SoundManager.PlaySound("prestige");
        }
    }

    public void reset(){
        prestigeBtn.gameObject.SetActive (false);
        hidden1.gameObject.SetActive(true);
        hidden2.gameObject.SetActive(false);
        hidden3.gameObject.SetActive(false);
        hidden4.gameObject.SetActive(false);
        hidden5.gameObject.SetActive(false);
        hidden6.gameObject.SetActive(false);
        hidden7.gameObject.SetActive(false);

        water1.gameObject.SetActive(false);
        water2.gameObject.SetActive(false);
        water3.gameObject.SetActive(false);
        water4.gameObject.SetActive(false);
        water5.gameObject.SetActive(false);
        water6.gameObject.SetActive(false);
        water7.gameObject.SetActive(false);
    }

    public void resetUnlock(){
        um1.cost = 15.0;
        um1.gpsCost = 0;
        um1.waterCount = 0;

        um2.cost = 100.0;
        um2.gpsCost = 0;
        um2.waterCount = 0;
        
        um3.cost = 1000.0;
        um3.gpsCost = 0;
        um3.waterCount = 0;

        um4.cost = 12000.0;
        um4.gpsCost = 0;
        um4.waterCount = 0;

        um5.cost = 130000.0;
        um5.gpsCost = 0;
        um5.waterCount = 0;

        um6.cost = 1400000.0;
        um6.gpsCost = 0;
        um6.waterCount = 0;

        um7.cost = 15000000.0;
        um7.gpsCost = 0;
        um7.waterCount = 0;
    }
}
