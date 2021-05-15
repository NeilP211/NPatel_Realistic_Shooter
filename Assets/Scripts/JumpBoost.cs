using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoost : MonoBehaviour
{
    

    // Update is called once per frame
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("hey");
        if (other.gameObject.CompareTag("Player")) 
        {
            Debug.Log("hello");
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-45, 30, 0), ForceMode.Impulse);
        }

    }
}
