
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody rb;
    public float forwardforce = 10f;

                            
	// Update is called once per frame
	void FixedUpdate () {
        //rb.AddForce(0, 0, forwardforce * Time.deltaTime); // Adds the movement not frame depent

        if (Input.GetKey("d") )
        {
            rb.AddForce(forwardforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

      

        }
        if (Input.GetKey("a") )
        {
            rb.AddForce(-forwardforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardforce * Time.deltaTime, ForceMode.VelocityChange);

        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardforce * Time.deltaTime ,ForceMode.VelocityChange);

        }












    }
}
