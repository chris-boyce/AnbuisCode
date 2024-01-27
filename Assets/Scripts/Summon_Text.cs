using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summon_Text : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public float SummonNumber = 1;
    public float Range2 = 1;
    private float Base = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) < 3)
        {
            summon();
        }
    }

    void summon()
    {
        DisplayText Summon = FindObjectOfType<DisplayText>();
        Summon.SummonText(SummonNumber);
    }
}
