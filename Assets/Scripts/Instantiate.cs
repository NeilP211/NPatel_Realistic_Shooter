using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //spawnPoint = player.transform;
        //spawnPoint.position = new Vector3(spawnPoint.position.x + 3f, spawnPoint.position.y, spawnPoint.position.z + 3f);
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet.GetComponent<Rigidbody>(), spawnPoint.position, spawnPoint.rotation);
            bulletInstance.AddForce(spawnPoint.forward * 3000f);
        }
    }
}