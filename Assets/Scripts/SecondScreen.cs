using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SecondScreen : MonoBehaviour
{
    public BG_Music music;
    public Text MusicOn;
    public Text MusicOff;
    public Button Mute;




    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.FindObjectOfType<BG_Music>();
        updateIconAndSound();        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MuteSound()
    {        
        music.mutePressed();
        updateIconAndSound();
        Debug.Log(music.isMuted);
    }

    public void updateIconAndSound()
    {
        if (PlayerPrefs.GetInt("MUTED") == 1)
        {
            AudioListener.pause = true;
            MusicOn.gameObject.SetActive(false);
            MusicOff.gameObject.SetActive(true);
        }
        else
        {
            AudioListener.pause = false;
            MusicOn.gameObject.SetActive(true);
            MusicOff.gameObject.SetActive(false);
        }
    }

}
