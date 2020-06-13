using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadTurn : MonoBehaviour
{
    public Transform Head;
    public Transform player;
    public float Distance_;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance_ = Vector3.Distance(Head.transform.position, player.transform.position);
        if (Distance_ <= 5)
        {
            transform.LookAt(player);
        }
            
    }
}
