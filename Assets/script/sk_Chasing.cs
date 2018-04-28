using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sk_Chasing : MonoBehaviour
{
    public Transform player;
    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        // set animator components that is attached to skeleton
    }

    // Update is called once per frame
    void Update()
    {
        //if (Vector3.Distance(player.position, this.transform.position) < 10)
        // { 
        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);
        if (Vector3.Distance(player.position, this.transform.position) < 10 && angle < 360)
        {
            direction.y = 0; // not to rotate upwards
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            // after we get closer to skeleton ..
            anim.SetBool("idle", false);
            if (direction.magnitude > 2)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("walking", true);
                anim.SetBool("attacking", false);
                //no idle to start walking
                // if we in 5 distance of skeleton we set walking to true
            }
            else
            {
                anim.SetBool("attacking", true);
                anim.SetBool("walking", false);

            }
        }
        /*
         if ( direction.magnitude > 5)
         {
             this.transform.Translate(0, 0, 0.0f);
         }
         //test distance bet player pos & skeleton pos
         // if less than 10 we will work out to direction from player to skeleton 
         //rotate using slerp */
        //  }
        else
        {
            anim.SetBool("adle", true);
            anim.SetBool("walking", false);
            anim.SetBool("attacking", false);

        }
        //restrict skeleton vision .. check if he is your view (in front) then he will chase you
        // calc angle bet forward direction of skeleton & player so we use vector3.angle fun
    }
   
    

}
