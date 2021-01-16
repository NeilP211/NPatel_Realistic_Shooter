using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_Uzi : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float Distance_;
    private int framecounter;
    public GameObject Head;
    public GameObject player;



    void Start()
    {
        framecounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        framecounter += 1;
        Distance_ = Vector3.Distance(Head.transform.position, player.transform.position);
        if (Distance_ <= 5 && framecounter > 60) 
        {
            framecounter = 0;
            Rigidbody bulletInstance;
            bulletInstance = Instantiate(bullet.GetComponent<Rigidbody>(), spawnPoint.position, spawnPoint.rotation);
            bulletInstance.AddForce(spawnPoint.forward * 2000f);
        }
    }
}
