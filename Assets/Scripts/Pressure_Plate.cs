using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressure_Plate : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject Gem;
    public GameObject Player;
	public float Range = 1;
    private bool work = false; 

    void Start()
    {
        Gem = GameObject.Find("pushable_block");
    }

    // Update is called once per frame
    void Update()
    {
        if (work == false)
        {
            if (Vector3.Distance(transform.position, Gem.transform.position) < Range)
            {
                pressed();

            }
        }
    }

    void pressed()
    {
        WinLose.Challege1 = true;
        WinLose.timer = 10;
        Response_Test Answer1 = FindObjectOfType<Response_Test>();
        Answer1.Answer();
        work = true;
    }
    void Awake()
    {


    }

}
