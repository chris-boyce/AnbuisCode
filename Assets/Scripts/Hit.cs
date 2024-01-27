using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hit : MonoBehaviour
{
    public GameObject bullet;
    public float health = 100f;
    public float damagemod = 10f;
    public static int death = 0;


    // Start is called before the first frame update
    void Start()
    {
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {

        bool hit = BulletMovement.hitstat;
        bool hit2 = MummyDamage.mummydam;
        if (hit == true)
        {
            health = health - damagemod;
            BulletMovement.hitstat = false;
            hit = false;
            //Light_Colour.DamageState = true;


        }
        if (hit2 == true)
        {
            health = health - damagemod;
            MummyDamage.mummydam = false;
            hit2 = false;
           // Light_Colour.DamageState = true;


        }

        if (health <= 0)
        {
            death = death + 1;
            SceneManager.LoadScene("GameScene");
        }



    }


}
