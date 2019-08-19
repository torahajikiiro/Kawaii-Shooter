using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Score Score;
    // public static int DeadCount = 0;

    void OnTriggerEnter(Collider other)
    {        
        if (other.CompareTag("Bullet"))
        {
            Score.DeadCount++;
            // DeadCount++;
            gameObject.SetActive(false);
        }
        Debug.Log("Something enter!");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Something exit!");
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Something stay!");
    }

}
