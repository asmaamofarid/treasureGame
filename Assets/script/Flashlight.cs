using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flashlight : MonoBehaviour
{
    public Light flashLight;
    public AudioSource audioSource;

    public AudioClip soundFlashlightOn;
    public AudioClip soundFlashlightOff;

    private bool isActive;

    // Use this for initialization
    void Start()
    {
        isActive = true;
    }

    // Update is called once per frame
    // Use this for Input
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isActive == false) //Toggle Flashlight On
            {
                flashLight.enabled = true;
                isActive = true;

                audioSource.PlayOneShot(soundFlashlightOn);
            }
            else if (isActive == true) //Toggle Flashlight Off
            {
                flashLight.enabled = false;
                isActive = false;

                audioSource.PlayOneShot(soundFlashlightOff);
            }
        }
    }
}
