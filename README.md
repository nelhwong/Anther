# Anther

This is a project for CS461/561 Open Source Software, Summer of 2020. 
Nelson Wong and Milan Mauck are both students that are trying to learn the game engine Unity to create a platformer game called Anther.

Anther is a basic platformer game where the user will collect gems, jump over, and fall a lot, in order to reach the end. The character will be in first person. 

# Installation
In order to work around with the project, you will need to download Unity Personal here: https://store.unity.com/#plans-individual

After you have Unity installed, you will clone the repo. After you have cloned it, you will be able to open the scences and interact with the game components. 

# Example Code

Here is some example code for platform movement. This function will only support two positions, p1 and p2. You can modify it to support more positions or you can add new variables to interact with the lerp. 
```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public Transform movingPlatform;

    public Transform p1; //pos 1
    public Transform p2; //pos 2
    public Vector3 new_p; // new pos
    public string currentState;
    public float smooth; //jerkiness of the movement
    public float resetTime; //how long the platform stays at each end
    // Start is called before the first frame update
    void Start()
    {
        ChangeTarget();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movingPlatform.position = Vector3.Lerp(movingPlatform.position, new_p, smooth * Time.deltaTime);

    }

    void ChangeTarget()
    {
        if (currentState == "Moving to p1")
        {
            currentState = "Moving to p2";
            new_p = p2.position;
        }
        else if (currentState == "Moving to p2")
        {
            currentState = "Moving to p1";
            new_p = p1.position;
        }
        else if (currentState == "")
        {
            currentState = "Moving to p2";
            new_p = p2.position;
        }

        Invoke("ChangeTarget", resetTime);
    }
} 
```
# Demo

Pause Menu: https://giant.gfycat.com/SilkyRespectfulGoosefish.webm

Level 1 and transition to level 2: https://giant.gfycat.com/CanineFluidHarvestmouse.webm

Level 2: https://giant.gfycat.com/CreativePettyIcefish.webm
