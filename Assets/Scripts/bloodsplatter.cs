using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloodsplatter : MonoBehaviour
{
    public ParticleSystem bloodSplatter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "projectile")
        {
            Debug.Log(other.gameObject.tag);
            Destroy(other.gameObject);
            bloodSplatter.Play();
        }


    }
}
