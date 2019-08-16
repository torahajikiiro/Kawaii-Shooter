using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public Vector3 Offset = new Vector3(1, 0, 0);
    public GameObject BulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // phan biet: class   vs instance
        // phan biet: human   vs Hieu
        // phan biet: Vector3 vs Offset
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var newBullet = Instantiate(BulletPrefab, transform.position + Offset, Quaternion.Euler(0, 0, 90));
        }
    }
}
