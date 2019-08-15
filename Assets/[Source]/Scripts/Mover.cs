using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    public float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        //gameObject.SetActive(false);
        //enabled = false;
       
    }

    // Update is called once per frame
    void Update() 
    {
        if( Input.GetKey(KeyCode.RightArrow)){
            var newPosition = transform.position;
            newPosition.x += MoveSpeed;
            transform.position = newPosition;
        }else  if( Input.GetKey(KeyCode.LeftArrow)){
            var newPosition = transform.position;
            newPosition.x -= MoveSpeed;
            transform.position = newPosition;
        }
        //Debug.Log("Update");
       
    }

}
