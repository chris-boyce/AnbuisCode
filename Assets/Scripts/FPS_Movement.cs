using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Movement : MonoBehaviour
{
    // Start is called before the first frame update
	public float fl_speed = 6f;
	private Vector3 v3_direction;
	private CharacterController cc_PC;
	public float gravity = 20f;
	public float fl_jump_force = 10f;
    void Start()
    {
        v3_direction = Vector3.zero;

		cc_PC = GetComponent<CharacterController> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc_PC.isGrounded) {
			v3_direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			v3_direction = fl_speed * transform.TransformDirection(v3_direction);
			cc_PC.Move(v3_direction * Time.deltaTime);
			if (Input.GetKey("space")) {
				v3_direction.y = fl_jump_force;
			}
		}
		else
		{
			v3_direction.y -= gravity * Time.deltaTime;
		}

		cc_PC.Move (v3_direction * Time.deltaTime);
    }
}
