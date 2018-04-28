using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PistolPickup : MonoBehaviour
{
    public AudioClip pickupSound;
    public GameObject pistol; //Actual Pistol under the FPS-Controler

    public GameObject ghoul; //Reference to the actuall enemy
    public GameObject ghoulWorldmodel; //Reference to the world model 

    public void PickupPistol()
    {
        GetComponent<AudioSource>().PlayOneShot(pickupSound);
        pistol.SetActive(true);

        ghoul.SetActive(true);
        ghoulWorldmodel.SetActive(false);

        Destroy(gameObject, pickupSound.length);
    }
}

