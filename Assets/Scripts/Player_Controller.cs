using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_Controller : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject gun;
    private Animator aa;
    public int health;
    public Health Health;


    void Start()
    {

        aa = gun.GetComponent<Animator>();

        rb = GetComponent<Rigidbody>();

        health = 5;

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("tracer"))
        {
             Health.DamagePlayer(3);
            Destroy(collision.gameObject);
        }
    }
    void FixedUpdate()
    {
         float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        aa.SetFloat("Movement", moveVertical);

        
        rb.AddForce(transform.forward * speed * moveVertical);
        rb.AddForce(transform.right * speed * moveHorizontal);
        
    }
}
