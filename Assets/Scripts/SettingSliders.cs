using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingSliders : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;
    float vol;
    // Start is called before the first frame update
    void Start()
    {
        vol = GetVolume();
        slider.value = vol;


    }

    public float GetVolume()
    {
        float value;        
        bool result = mixer.GetFloat("volume", out value);        
        if (result)
        {
            return value;
        }
        else
        {
            return 0f;
        }
        
    }
}
