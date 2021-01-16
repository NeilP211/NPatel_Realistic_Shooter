using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate3 : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public GameObject player;
    private float nextFire;
    public float fireRate;
    public AudioSource shootingsound;


    void Start()
    {
         shootingsound = GetComponent<AudioSource>();
         nextFire = 0.0f;
         fireRate = 0.00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001f;
    }

    void Update()
    {

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet.GetComponent<Rigidbody>(), spawnPoint.position, spawnPoint.rotation);
            bulletInstance.AddForce(spawnPoint.forward * 2000f);
            shootingsound.Play();
        }
    }
}