using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverCheck : MonoBehaviour
    
{
    private bool work = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (work == false)
        {
            if (LeverRotate.levercheck + LeverCheck1.levercheck1 + LeverCheck2.levercheck2 + LeverCheck3.levercheck3 == 4)
            {

                WinLose.Challege2 = true;
                print(" Looping broke ");
                WinLose.timer = 10;
                work = true;

            }
        }
    }

    
}
