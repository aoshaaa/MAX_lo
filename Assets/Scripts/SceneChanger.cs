using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SceneChanger : MonoBehaviour
{
    AudioMixer mixer;
    Slider slider;
    public void changeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
       
    }
}
