using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float sensitivityX = 15F;
    public float sensitivityY = 15F;

    public Transform orientation;

    private float xRotation;
    private float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivityX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivityY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -1f, 1f);

        transform.rotation = quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = quaternion.Euler(0, yRotation, 0);

    }


}
