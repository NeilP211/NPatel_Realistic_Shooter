using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyedwhenshot : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "thetag")
            Destroy(gameObject);
    }
}
