﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTurn : MonoBehaviour
{
    public Transform Head;
    public Transform player;
    public float Distance_;
    Animator animator;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Distance",Distance_);
        Distance_ = Vector3.Distance(Head.transform.position, player.transform.position);
        if (Distance_ <= 5)
        {
            transform.LookAt(player);
            rb.AddForce(transform.forward * 10000);
        }
            
    }
}