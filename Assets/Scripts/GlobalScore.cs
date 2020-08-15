//Referenced from Jimmy Vegas https://youtu.be/7Ow3b1DfGmo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour
{

    public GameObject scoreBox;
    public static int currentScore;
    public int internalScore;

    void Update()
    {
        internalScore = currentScore;
        scoreBox.GetComponent<Text>().text = "" + internalScore;
    }
}



