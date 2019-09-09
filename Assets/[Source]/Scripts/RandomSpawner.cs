using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public float Radius;
    public Vector3 Center;

    public void SpawnObject(GameObject prefab)
    {
        var position = Center + (Vector3)Random.insideUnitCircle * Radius;
        Instantiate(prefab, position, Quaternion.Euler(0, 0, 0));
    }

}
