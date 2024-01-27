using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.transform.position) < 2)
        {
            print("IN range");
            SceneManager.LoadScene("Win Scene");
        }
    }
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.name == "PC_Player")
    //    {
    //        SceneManager.LoadScene("Win Scene");
    //    }
    //}
}
