using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonespam : MonoBehaviour
{
    public GameObject Omega;
    public GameObject Parent;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Omega, new Vector3(i * 1.0F, 0, 0), Quaternion.identity, Parent.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
