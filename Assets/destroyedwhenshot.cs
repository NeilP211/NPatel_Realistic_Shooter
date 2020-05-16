using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyedwhenshot : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "projectile")
            Destroy(gameObject);
        Debug.Log(other.gameObject.tag);
    }
}
