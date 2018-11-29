using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hazard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Debug.Log("player entered hazard");
            SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("something other than the player entered the hazard");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
