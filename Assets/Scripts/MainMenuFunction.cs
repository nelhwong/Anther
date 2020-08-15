//Referenced from Jimmy Vegas https://youtu.be/7Ow3b1DfGmo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunction : MonoBehaviour
{

    public AudioSource buttonPress;
    public int bestScore;
    public GameObject bestScoreDisplay;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreDisplay.GetComponent<Text>().text = "BEST: " + bestScore;
    }

    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 2;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetBest()
    {
        PlayerPrefs.SetInt("LevelScore", 0);
        bestScoreDisplay.GetComponent<Text>().text = "BEST: " + bestScore;

    }
}
