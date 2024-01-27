using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public static int completed = 0;
    public GameObject me;
    public GameObject door;
    private int  deathcount;
    public static bool Challege1 = false;
    public static bool Challege2 = false;
    public static bool Challege3 = false;
    public static float timer = 10;
    private float timeleft = 10;
    // Start is called before the first frame update


    void Start()
    {

        DontDestroyOnLoad(me);
    }

    // Update is called once per frame
    void Update()
    {

        if (Challege1 == true)
        {

            //Light_Colour.WinState = true;
            timer = timer - Time.deltaTime;
            timeleft = timer;


            if (timeleft <= 0)
            {
               //Light_Colour.WinState = false;

                timeleft = 100000;

            }

        }
        if (Challege2 == true)
        {

            //Light_Colour.WinState = true;
            timer = timer - Time.deltaTime;
            timeleft = timer;


            if (timeleft <= 0)
            {
                //Light_Colour.WinState = false;

                timeleft = 100000;

            }

        }
        if (Challege1 == true && Challege2 == true)

        {

            Destroy(door);
        }




    }
}
