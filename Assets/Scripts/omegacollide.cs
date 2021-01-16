using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omegacollide : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "OMEGA")
            Destroy(gameObject);
        Debug.Log(other.gameObject.tag);
    }
}
