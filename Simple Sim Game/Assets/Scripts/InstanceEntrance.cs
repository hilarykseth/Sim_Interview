using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstanceEntrance : MonoBehaviour
{

    /*void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Indoor");
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Indoor");
        }
    }
}
