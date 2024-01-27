using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverRotate : MonoBehaviour
{
    public Rigidbody rb; // Sets Rigibody of the lever
    public Rigidbody playerTarget; // Set person 
    private bool UpDownCheck = false; 
    public static int levercheck ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if ((Vector3.Distance(transform.position, playerTarget.transform.position) < 0.9))// Checks if player is near lever
        {
            if (levercheck == 1)// Used to make sure running the right part of the script
            {

                if (Input.GetKeyUp("e"))// input buttin
                {
                    rb.transform.Rotate(180, 0, 0);
                    levercheck = 0; // setting value to 0 for LeverCheck.cs to add to make postive outcome
                }
            }


            else
            {

                if (Input.GetKeyUp("e"))
                {
                    rb.transform.Rotate(180, 0, 0);
                    UpDownCheck = true;
                    LeverChecker();
                }


            }





        }






    }
    void LeverChecker () // function to add 1 if lever is pushed "Had to be seperate function to allow not repeating every frame
    {
        if (UpDownCheck == true)
        {
            levercheck =  1;

        }
    }
}






