using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GameManager;

public class testing : MonoBehaviour
{
    public Image bar12;
    public float time = 3;
    float runtime = 0;

    public void runBar()
    {
        StartCoroutine(barRunningcoroutine());
    }

    IEnumerator barRunningcoroutine()
    {
        bar12.fillAmount = 0;
        while (bar12.fillAmount < 1)
        {
            runtime += Time.deltaTime;
            bar12.fillAmount = runtime / time;
            yield return null;
        }
        runtime = 0;
        gm.addCharisma(2);
        time *= 1.5f;
       

    }
}
