using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushRotate : MonoBehaviour { 

    //Varibles ------------------

    public Rigidbody rb;
    private bool control;
	public GameObject Player;

    // Start ----------------------------
    void Start()
    {
        
    }

    // Update --------------------
    void Update()
    {
		if (Vector3.Distance(transform.position, Player.transform.position) < 2) // In range --------------------
		{
			if (control == true)
			{
				if (Input.GetKey("e")) // Gets Input
				{
					transform.Translate(Vector3.right * 1  * Time.deltaTime); // Movement
				}
				if (Input.GetKeyDown("f")) // gets input
				{
					rb.transform.Rotate(0, 0, 90); // rotates object
				}

	        }   
		}
	}

    void OnCollisionEnter(Collision collision) //Collisions --------------------------

    {




        

            control = true; 



       
    }



}
