using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public GameObject gun1;
    public GameObject gun2;
    public GameObject gun3;


    private void Hide()

    {
        gun1.SetActive(false);
        gun2.SetActive(false);
        gun3.SetActive(false);

    }

    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Hide();
            gun1.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Hide();
            gun2.SetActive(true);
        }
        
   
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Hide();
            gun3.SetActive(true);
        }

    }

}
