using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public float timeRemaining = 60;
    public bool timerIsRunning = false;
    public Rigidbody rb;

    void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                rb.isKinematic = false;
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }
}


