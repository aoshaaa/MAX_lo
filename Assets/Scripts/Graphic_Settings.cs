using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Graphic_Settings : MonoBehaviour
{
           
   

    public void setGraphic(int graphicIndex)
    {
         QualitySettings.SetQualityLevel(graphicIndex);
        int textureQuality = graphicIndex;
        PlayerPrefs.SetInt("TextureQuality", textureQuality);
        PlayerPrefs.Save();        
    }

    public void setFullScreen(bool isFullScreen)
    {
        if (isFullScreen)
        {
            Resolution[] allResolutions = Screen.resolutions;
            Resolution maxResolution = allResolutions[allResolutions.Length - 1];
            Screen.SetResolution(maxResolution.width, maxResolution.height, true);
            Debug.Log("full");
        }
    }
}
