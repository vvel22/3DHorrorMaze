using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight;
    private bool isOn = true;

    void Start()
    {
        flashlight.enabled = isOn;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isOn = !isOn;
            flashlight.enabled = isOn;
        }
    }
}