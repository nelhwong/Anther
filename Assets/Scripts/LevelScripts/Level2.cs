﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fadeIn;
    void Start()
    {
        RedirectToLevel.redirectToLevel = 2;
        RedirectToLevel.nextLevel = 3;

        StartCoroutine(FadeInOff());

    }

    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

}
