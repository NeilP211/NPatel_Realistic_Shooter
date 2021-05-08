using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public AudioSource udio;
    [SerializeField] public RawImage customImage;
    public GameObject player;
    public GameObject xtraCamera;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    // Update is called once per frame
 //   void Update()
//    {
  //       if (Input.GetKeyDown(KeyCode.Space))
  //      {
  //          DamagePlayer(10);
   //     }
  //  }

    public void DamagePlayer(int damage)
    {

        curHealth -= damage;

        healthBar.SetHealth(curHealth);
        if (curHealth <= 45)
        {
            customImage.enabled = true;
            udio.Play();
            player = new GameObject();
            xtraCamera.GetComponent<Camera>().enabled = true;
        }
    }
}