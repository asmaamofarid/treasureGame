using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pistol : MonoBehaviour
{
    public int damage = 50;
    public int ammo = 20;
    //Optional
    public float range = 50;

    private Transform mainCamera;

    private AudioSource myAudioSource;
    public AudioClip shootSound;

    // Use this for initialization
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Raycast
        Ray ray = new Ray(mainCamera.position, mainCamera.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, range))
        {
            if (hit.collider.CompareTag("Enemy"))
            {
                //Damage the Enemy

                Debug.Log("we hit an enemy , yaah");

               //hit.collider.GetComponent<Enemy_Health>().TakeDamage(damage);
            }
        }

          myAudioSource.PlayOneShot(shootSound);
         ammo--;
    }
}
