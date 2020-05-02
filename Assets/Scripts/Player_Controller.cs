using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject gun;
    private Animator aa;


    void Start()
    {

        aa = gun.GetComponent<Animator>();

        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        aa.SetFloat("movement", moveVertical);


        rb.AddForce(transform.forward * speed * moveVertical);
        rb.AddForce(transform.right * speed * moveHorizontal);
    }
}
