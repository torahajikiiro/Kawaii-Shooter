using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    // public ScoreController Score;
    // public static int DeadCount = 0;

    void Awake()
    {
        GameManager.ListEnemyController.Add(this);
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            GameManager.OnEnemyDie(this);
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
