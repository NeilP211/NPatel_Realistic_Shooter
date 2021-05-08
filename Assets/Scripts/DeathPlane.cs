using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    public AudioSource udio;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "DEATH")
        {
            udio.Play();
            gameObject.transform.position = new Vector3(-1528, 7, -17);
        }
            
            
        Debug.Log(other.gameObject.tag);
    }
}
