using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class Graphic_Settings : MonoBehaviour
{
    Resolution[] resolutions;
    public Dropdown _resolutinDropdown;
    public Toggle _fullscreenToggle;
    bool isFoolScreenNow;

    private void Start()
    {                 
        resolutions = Screen.resolutions;
        _resolutinDropdown.ClearOptions();
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

      
            for (int i = 0; i < resolutions.Length; i++)
            {
                string option = resolutions[i].width + "x" + resolutions[i].height + " " + resolutions[i].refreshRate.ToString() + " Hz";
                options.Add(option);
                if (resolutions[i].width == Screen.currentResolution.width &&
                    resolutions[i].height == Screen.currentResolution.width)
                {
                    currentResolutionIndex = i;
                }
            }
            _resolutinDropdown.AddOptions(options);
            _resolutinDropdown.value = currentResolutionIndex;
            _resolutinDropdown.RefreshShownValue();

        isFoolScreenNow = (PlayerPrefs.GetInt("Fullscreen") == 1);
        Debug.Log("isFoolScreenNow" + isFoolScreenNow);        
        if(!isFoolScreenNow)
        {
            SetResolution(PlayerPrefs.GetInt("Current Resolution"));
            _fullscreenToggle.isOn = false;
        }
        else
        {
            setFullScreen(true);
            _fullscreenToggle.isOn = true;
        }
        
    }
    

    public void setGraphic(int graphicIndex)
    {
         QualitySettings.SetQualityLevel(graphicIndex);
        int textureQuality = graphicIndex;
        PlayerPrefs.SetInt("TextureQuality", textureQuality);
        PlayerPrefs.Save();        
    }


    public void SetResolution(int resolutionIndex)
    {        
        Resolution _resolution = resolutions[resolutionIndex];               
        Screen.SetResolution(_resolution.height, _resolution.width, Screen.fullScreen);        
        PlayerPrefs.SetInt("Current Resolution", resolutionIndex);
        PlayerPrefs.Save();
    }
     
    public void setFullScreen(bool isFullScreen)
    {
        Debug.Log(isFullScreen);
        if (isFullScreen)
        {
            Resolution[] allResolutions = Screen.resolutions;
            Resolution maxResolution = allResolutions[allResolutions.Length - 1];
            Screen.SetResolution(maxResolution.width, maxResolution.height, true);
        }
        else
        {
            SetResolution(PlayerPrefs.GetInt("Current Resolution"));
        }
        
        PlayerPrefs.SetInt("Fullscreen", ((isFullScreen)?1:0));
        PlayerPrefs.Save();
    }
}
