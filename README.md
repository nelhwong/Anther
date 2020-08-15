# Anther

This is a project for CS461/561 Open Source Software, Summer of 2020. 
Nelson Wong and Milan Mauck are both students that are trying to learn the game engine Unity to create a platformer game called Anther.

Anther is a basic platformer game where the user will collect gems, jump over, and fall a lot, in order to reach the end. The character will be in first person. 

# Installation
In order to work around with the project, you will need to download Unity Personal here: https://store.unity.com/#plans-individual

After you have Unity installed, you will clone the repo. After you have cloned it, you will be able to open the scences and interact with the game components. 

# Example Code

If you'd like to contribute, below are some code examples of how certain features were implemented.
## Bounce pads
In order to get the yellow bounce pads to bounce the character, the following code was implemented in the Player's controller script.
A simple collision detector, checking if the object we've hit has the tag "Bouncy". If so, reflect the force vector (with a little extra force, just for fun).
This code resides in Assets/Imports/Standard Assets/Characters/FirstPersonCharacter/Scripts/RigidbodyFirstPersonController.cs
``` 
void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.tag == "Bouncy")
    {
        float kr = 0.5f;
        Vector3 v = GetComponent<Rigidbody>().velocity;
        Vector3 n = collision.contacts[0].normal;
        Vector3 vn = Vector3.Dot(v, n) * n;
        Vector3 vt = v - vn;
        Vector3 bounce = vt - (vn * kr);
        m_RigidBody.AddForce(bounce * 10f, ForceMode.Impulse);
    }
}
```
## Speed pads
In order to get the blue pads to give the player a speed boost, the following code was implemented in the Player's controller script, inside FixedUpdate().
Here we are doing a spherecast at the bottom of the player's collider, checking for any speed pads. If we hit one, we boost our speed by a little.
This code resides in Assets/Imports/Standard Assets/Characters/FirstPersonCharacter/Scripts/RigidbodyFirstPersonController.cs
``` 
// ^ Inside FixedUpdate()
if (Physics.SphereCast(transform.position, 0.3f, Vector3.down, out hitInfo, ((m_Capsule.height / 2f) - m_Capsule.radius) + advancedSettings.stickToGroundHelperDistance, Physics.AllLayers, QueryTriggerInteraction.Ignore))
{
    if (hitInfo.transform.gameObject.tag != "Speedy")
    {
        movementSettings.ForwardSpeed = 12;
    }
    else
    {
        movementSettings.ForwardSpeed = 8;
    }
}

```
## Plaform Movement

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
