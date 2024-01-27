using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BasicAI : MonoBehaviour
{
    public Transform PC_Play;               // Reference to the player's position.
    public Transform ReturnCube;
    public NavMeshAgent nav;               // Reference to the nav mesh agent.
    private bool playertar = true;


    void Start()
    {


        PC_Play = GameObject.Find("PC_Player").transform;
        ReturnCube = GameObject.Find("ReturnCube").transform;



    }


    void Update()

    {
        nav.SetDestination(ReturnCube.position);
        if (playertar == false)
        {
            nav.SetDestination(ReturnCube.position);
        }
        if (playertar == true)
        {
            
        }



      nav.SetDestination(PC_Play.position);
    }
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.name == "PC_Player")
        {
            transform.position = new Vector3(1, 1, -25);
        }
        if (collisioninfo.collider.name == "ReturnCube")
        {

            playertar = true;
        }
    }
}

        




    

