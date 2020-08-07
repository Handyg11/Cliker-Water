using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPSManager : MonoBehaviour
{
    public GameControllerScript gcs;
    public upgradeManager[] um;

    public Text gpsDisplay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Autotick());
    }

    // Update is called once per frame
    void Update()
    {
        gpsDisplay.text = GetGPS().ToString("F2");
    }

    public double GetGPS(){
        double tick = 0.0f;
        foreach(upgradeManager item in um){
            tick = gcs.gpsAmount;
        }return tick;
    }
    public void AutoGPS(){
        gcs.moneyAmount += GetGPS();
    }

    IEnumerator Autotick(){
        while(true){
            AutoGPS();
            yield return new WaitForSeconds(1);
        }
    }
}
