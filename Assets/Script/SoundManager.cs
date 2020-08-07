using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip clickSound, upgradeSound, prestigeSound;
    static AudioSource asrc;
    // Start is called before the first frame update
    void Start()
    {
        clickSound = Resources.Load<AudioClip>("click");
        upgradeSound = Resources.Load<AudioClip>("upgrade");
        prestigeSound = Resources.Load<AudioClip>("prestige");
        asrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string audio){
        switch(audio){
            case "click":
                asrc.PlayOneShot(clickSound);
                break;
            case "upgrade":
                asrc.PlayOneShot(upgradeSound);
                break;
            case "prestige":
                asrc.PlayOneShot(prestigeSound);
                break;
        }
    }
}
