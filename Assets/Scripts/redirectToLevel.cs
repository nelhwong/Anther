using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class redirectToLevel : MonoBehaviour
{

    public static int redirectToLevel_ = 1;


    // Update is called once per frame
    void Update()
    {
        if(redirectToLevel_ == 1)
        {
            SceneManager.LoadScene(redirectToLevel_);
        }
    }
}
