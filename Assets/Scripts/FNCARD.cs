using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FNCARD : MonoBehaviour
{
    public AudioSource udio;

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Card")
        {
            udio.Play();
        }


        Debug.Log(other.gameObject.tag);
    }
}