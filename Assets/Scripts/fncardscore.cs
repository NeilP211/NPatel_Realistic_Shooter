using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class fncardscore : MonoBehaviour
{

    public GameObject scoreText;
    public int theScore;
    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        theScore += 50;
        scoreText.GetComponent<Text>().text = "Shares: " + theScore;
        if (theScore == 1000000){
            GameObject.Find("Player").GetComponent<Fly>().flyer = true;
        }
    }
}
