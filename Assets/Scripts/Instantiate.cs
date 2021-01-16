using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public GameObject player;
    public AudioSource shootingsound;


    void Start()
    {
        shootingsound = GetComponent<AudioSource>();
    }
    
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {

            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet.GetComponent<Rigidbody>(), spawnPoint.position, spawnPoint.rotation);
            bulletInstance.AddForce(spawnPoint.forward * 20000f);
            shootingsound.Play();
        }
    }
}