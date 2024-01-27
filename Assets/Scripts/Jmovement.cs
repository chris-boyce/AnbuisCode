using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PF_PC_movement : MonoBehaviour
{
    public float fl_speed = 6f;
    public float fl_jump_force = 10f;
    public float gravity = 20f;
    public float Vspeed = 2.0f;
    public float Hspeed = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f; 

    private Vector3 v3_direction;
    private CharacterController cc_PC;


    void Start()
    {
        v3_direction = Vector3.zero;
        cc_PC = GetComponent<CharacterController> ();
    }




    void Update()
    {

//=============Look==================

        yaw += Hspeed * Input.GetAxis("Mouse X");
        pitch -= Vspeed * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);

//=================Movement & Gravity==================

        if (!cc_PC.isGrounded)
        {
v3_direction.y -= gravity * Time.deltaTime;
        }

        else
        {
v3_direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
v3_direction = fl_speed * transform.TransformDirection(v3_direction);
            if (Input.GetKey("space"))
{
                v3_direction.y = fl_jump_force;
}
        }
cc_PC.Move(v3_direction * Time.deltaTime);
//============Sprint=================

if (Input.GetKey("left shift"))
{
fl_speed = 12f;
}
else 
{
fl_speed = 6f;
}
        
    }
}