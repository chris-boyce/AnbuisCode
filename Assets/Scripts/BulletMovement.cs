using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    //Variables ---------
    private GameObject playerTarget;
    public Transform tr_player;
    public float fl_speed = 20f;
    Vector3 target;
    public float timeleft = 2;
    public GameObject balls;
    public AudioClip shootsound;
    private AudioSource source;
    public static bool hitstat = false;
   
    // Start of program -------------


    void Start()
    {
        playerTarget = GameObject.Find("Cube");
        target = new Vector3(tr_player.position.x, this.transform.position.y, tr_player.position.z);
        transform.LookAt(target);

        source = GetComponent <AudioSource>();// Audio 
        source.PlayOneShot(shootsound, 1f);// Audio plays as soon as bullet spawns

    }

    // Update ----------------------
    void Update()
    {

        Movement(); // Bullet always moving



    }
    // When Colliding ------------------------
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.name == "MapLayout") // When hit map
 
        {

            Destroy(gameObject);
        }
        if (collisioninfo.collider.name == "PC_Player") // When Hit player
        {
            print("Bullet Damage");
            hitstat = true;
    
            Destroy(gameObject);
        }


    }

    // Moving function ------------------------

    void Movement()
    {
        transform.Translate(Vector3.forward * fl_speed * Time.deltaTime);
    }











}
