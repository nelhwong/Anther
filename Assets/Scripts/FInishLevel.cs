using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    //public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;

    void OnTriggerEnter()
    {
        //levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
    }

}