using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class Quality_Dropdown : MonoBehaviour
{
    Dropdown _dropdown;

    // Start is called before the first frame update

    // Update is called once per frame
    void Start()
    {
        _dropdown = GetComponent<Dropdown>();
        _dropdown.value = PlayerPrefs.GetInt("TextureQuality");
    }

    private void Update()
    {
        
        Debug.Log(_dropdown.value);
    }
}
