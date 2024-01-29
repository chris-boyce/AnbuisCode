using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxOpenBox : MonoBehaviour
{
    public Vector3 firstOffset = new Vector3(2f, 0f, 0f);
    public Vector3 secOffset = new Vector3(4f, 0f, 0f);
    public float firstAnimTime = 2.0f;
    public float secondAnimTime = 3f;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpenDoor();
            Destroy(GetComponent<BoxCollider>());
        }
    }

    void OpenDoor()
    {
        Vector3 firstPos = initialPosition + firstOffset;

        LeanTween.move(gameObject, firstPos, firstAnimTime).setOnComplete(OpenDoorTwo);
    }

    void OpenDoorTwo()
    {
        Vector3 secPos = initialPosition + secOffset;
        LeanTween.move(gameObject, secPos, secondAnimTime);
    }

}
