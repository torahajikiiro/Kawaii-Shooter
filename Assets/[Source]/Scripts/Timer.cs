using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float TimeCountdown;
    public System.Action CallbackOnTimeUp;

    public void BeginCountdown(float time)
    {
        TimeCountdown = time;
        enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCountdown -= Time.deltaTime;
        if (TimeCountdown <= 0)
        {           
            enabled = false;
            if (CallbackOnTimeUp != null)
            {
                CallbackOnTimeUp.Invoke();
            }
        }
    }
    
}
