using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayObj : MonoBehaviour
{
    public GameObject hoverBonus;
    public Text bonusText;
    public GameControllerScript gcs;

    // void Start(){
    //     hoverBonus.SetActive(false);
    // }
    public void OnMouseEnter(){
        if(gcs.prestigePercent >= 0.01){
            hoverBonus.SetActive(true);
            if(hoverBonus != null){
                bonusText.text = "Bonus " + gcs.prestigePercent.ToString("F2") + "%";
                Debug.Log(gcs.prestigePercent);
            }
        }
        else {
            hoverBonus.SetActive(false);
        }
    }
    public void OnMouseExit(){
        hoverBonus.SetActive(false);
    }
}
