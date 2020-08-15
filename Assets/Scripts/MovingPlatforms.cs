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