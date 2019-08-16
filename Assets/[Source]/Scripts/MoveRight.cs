using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            var newPosition = transform.position;
            newPosition.x += MoveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}
