using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PF_PC_Movement_Fast : MonoBehaviour {

		// Use this for initialization
	public float fl_speed = 12f;
	public float fl_turn_speed = 180;
	public float fl_jump_force = 20f;
	public float gravity = 20f;
	private Vector3 v3_direction;
	private CharacterController cc_PC;
	void Start () {
		v3_direction = Vector3.zero;

		cc_PC = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (cc_PC.isGrounded) {
			transform.Rotate (0, (fl_turn_speed * Input.GetAxis ("Horizontal") * Time.deltaTime), 0);

			v3_direction = new Vector3(0, 0, Input.GetAxis("Vertical"));

			v3_direction = fl_speed * transform.TransformDirection(v3_direction);

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
