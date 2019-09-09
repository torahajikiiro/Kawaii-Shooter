using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static ScoreController ScoreController;

    public static EnemySpawnerController EnemySpawnerController;
    public static List<EnemyController> ListEnemyController = new List<EnemyController>();

    public static void OnEnemyDie(EnemyController enemyController)
    {
        ScoreController.AddScore(1);
        enemyController.Die();
    }

    public static void OnReachGoal()
    {
        ScoreController.ShowWinning();
        EnemySpawnerController.StopSpawning();
    }

}
