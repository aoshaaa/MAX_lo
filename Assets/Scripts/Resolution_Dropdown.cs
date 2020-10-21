using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Dropdown))]
public class Resolution_Dropdown : MonoBehaviour
{
    Dropdown _dropdown;
    // Start is called before the first frame update
    void Start()
    {
        _dropdown = GetComponent<Dropdown>();
        _dropdown.value = PlayerPrefs.GetInt("Current Resolution");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
