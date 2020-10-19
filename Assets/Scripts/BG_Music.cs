using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BG_Music : MonoBehaviour
{
    public AudioMixer audiomixer;
    public bool isMuted;
    public Button muteButton;
    public Text musicOnText;
    public Text musicOffText;



    // Use this for initialization
    void Start()
    {
        isMuted = PlayerPrefs.GetInt("MUTED") == 1;
        AudioListener.pause = isMuted;

    }

    //Play Global
    private static BG_Music instance = null;
    public static BG_Music Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
    //Play Gobal End

    // Update is called once per frame
    public void setVolume(float volume)
    {
        audiomixer.SetFloat("volume", volume);
    }
    public void mutePressed()
    {
        isMuted = !isMuted;            
        PlayerPrefs.SetInt("MUTED", isMuted ? 1 : 0);
     
    }
    
}