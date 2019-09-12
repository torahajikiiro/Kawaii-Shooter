using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Lean.Touch;

public class Mover : MonoBehaviour
{

    public float MoveSpeed;
    public float Sensitive;
    public Camera Camera;

    // Start is called before the first frame update
    void Start()
    {        
        //gameObject.SetActive(false);
        //enabled = false;
        LeanTouch.OnFingerSet += OnTouch;
    }

    void OnTouch(LeanFinger finger)
    {
        var camera = LeanTouch.GetCamera(Camera, gameObject);
        // world unit -> pixel -> pixel + delta (pixel) -> unit
        if (camera != null)

        {
            // Screen position of the transform
            var screenPoint = camera.WorldToScreenPoint(transform.position);

            // Add the deltaPosition
            screenPoint += (Vector3)finger.ScreenDelta * Sensitive;

            // Convert back to world space
            transform.position = camera.ScreenToWorldPoint(screenPoint);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // move speed = 1;
        // 60 FPS: 1s -> 60 unit => deltatime = 1s/60 = ...
        // 20 FPS: 1s -> 20 unit => 1s -> 60 unit => delta time = 1s/20
        // => Time.deltaTime: khoang thoi gian tu lan update truoc
        // alt shift A
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            var newPosition = transform.position;
            newPosition.x += MoveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            var newPosition = transform.position;
            newPosition.x -= MoveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            var newPosition = transform.position;
            newPosition.y += MoveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            var newPosition = transform.position;
            newPosition.y -= MoveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }

        //Debug.Log("Update");

    }

}