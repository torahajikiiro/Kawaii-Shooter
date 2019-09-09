using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Spawn enemy vi tri random sau 1 khoang thoi gian co dinh

// -> Thong bao thoi gian delay ket thuc
// -> Spawn object o vi tri random
public class EnemySpawnerController : MonoBehaviour
{

    public float Countdown;
    public Timer Timer;
    public RandomSpawner RandomSpawner;
    public GameObject PrefabEnemy;

    void Awake()
    {
        GameManager.EnemySpawnerController = this;
        Timer.CallbackOnTimeUp += OnTimeUp;
    }

    // Start is called before the first frame update
    void Start()
    {
        Timer.BeginCountdown(Countdown);
    }

    void OnTimeUp()
    {
        RandomSpawner.SpawnObject(PrefabEnemy);
        Timer.BeginCountdown(Countdown);
    }

    public void StopSpawning()
    {
        gameObject.SetActive(false);
    }


}
