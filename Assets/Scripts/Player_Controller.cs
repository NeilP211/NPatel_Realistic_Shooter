using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;


    void Start()
    {


        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");



        rb.AddForce(transform.forward * speed * moveVertical);
        rb.AddForce(transform.right * speed * moveHorizontal);
    }
}
