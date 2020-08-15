//Referenced from Jimmy Vegas https://youtu.be/7Ow3b1DfGmo
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemGold : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {

        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
    }
}
