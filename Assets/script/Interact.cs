using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public string interactButton;

    public float interactDistance = 3f;
    public LayerMask interactLayer; //Filter

    public Image interactIcon; // Picture to show if you can interact or not

    public bool isInteracting;

    // Use this for initialization
    void Start()
    {
        //Set Interact icon to be invisible
        if (interactIcon != null)
        {
            interactIcon.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        //Shoots a ray
        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            //Checks if we are not interacting
            if (isInteracting == false)
            {
                if (interactIcon != null)
                {
                    interactIcon.enabled = true;
                }

                //If we press the interaction button
                if (Input.GetButtonDown(interactButton))
                {
                    ////If it is a door
                    //if (hit.collider.CompareTag("Door"))
                    //{
                    //    //Open/Close it
                    //    hit.collider.GetComponent<Door>().ChangeDoorState();
                    //}
                    //else if (hit.collider.CompareTag("Key"))
                    //{
                    //    hit.collider.GetComponent<Key>().UnlockDoor();
                    //}
                    //else if (hit.collider.CompareTag("Safe"))
                    //{
                    //    hit.collider.GetComponent<Safe>().ShowSafeCanvas();
                    //}
                    //else if (hit.collider.CompareTag("Note"))
                    //{
                    //    hit.collider.GetComponent<Note>().ShowNoteImage();
                    }
                   // else
                    if (hit.collider.CompareTag("Pistol"))
                    {
                        hit.collider.GetComponent<PistolPickup>().PickupPistol();
                    }
                }
            }
        }
   //     else
   //     {
   //         interactIcon.enabled = false;
   //     }
    }
//}
