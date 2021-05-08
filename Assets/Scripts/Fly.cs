using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private Rigidbody rb;
    public bool flyer;

    // Start is called before the first frame update
    void Start()
    {
        flyer = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && flyer) 
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }

    }
}
