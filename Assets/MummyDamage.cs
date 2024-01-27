using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyDamage : MonoBehaviour
{
    public static bool mummydam = false;
    public Rigidbody playertarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.name == "PC_Player")
        {
            print("Damage From mummy");
            mummydam = true;
        }
    }
}
