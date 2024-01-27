using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTurret : MonoBehaviour
{
    //Variables ---------
    private GameObject playerTarget; // Sets the Main target
    public Transform tr_player; // Looks at the transform of the player
    public float fl_speed = 0f; // Makes turret not move
    Vector3 target;// x,y,z axis 
    public GameObject bullet; // linking object to code
    private bool shotready = false; // Limits spawns of bullets
    public float firetimer;// Base timer
    public float timeleft; // Time for bullet spawns
    //---------------------

    void Shoot()//Shooting Fucntion that spawn the bullets 

    {
        Transform CB_bullet = Instantiate(bullet.transform, transform.transform.position, Quaternion.identity);// Spawn Bullets
        shotready = false; // Loops back to the timer

    }

    void Start()// At start of the game 
    {
        playerTarget = GameObject.Find("PC_Player"); // Sets target

        shotready = true; // Makes sure bullets can fire
    }

    
    void Update() // All functions done once per frame
    {
        if ((Vector3.Distance(transform.position, playerTarget.transform.position) < 10)) // If player is in range
            
        {

            if (shotready == true) // Ask if shot is ready
            {

                Shoot(); // Fires bullet
                shotready = false; // Resets the firing 

            }


            target = new Vector3(tr_player.position.x, 0, tr_player.position.z); // Looking for player

            transform.LookAt(target); // Looks makes the play look at target

            transform.Translate(Vector3.forward * 0 * Time.deltaTime); // Movement if you wanted to make into moving turret

        }

        timeleft -= Time.deltaTime; // Loop for timer 
        if (timeleft < 0)
        {
            shotready = true;
            timeleft = 2f;
        }


    }
}
