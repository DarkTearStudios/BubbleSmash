using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{


    public bool isMute;

    
    void Start()
    {
        PlayerPrefs.GetFloat("music");
    }

    public void MuteToggle()
    {
        isMute = !isMute;
        if (isMute == true)
        {
            AudioListener.volume = 0;
            PlayerPrefs.SetFloat("music", 0);
        }
        else
        {
            AudioListener.volume = 1;
            PlayerPrefs.SetFloat("music", 1);
        }
    }
}
