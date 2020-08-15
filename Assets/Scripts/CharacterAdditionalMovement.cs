using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAdditionalMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            Quaternion combinedForward = transform.localRotation;
            combinedForward.x = transform.Find("MainCamera").localRotation.x;
            transform.Translate((transform.Find("MainCamera").forward + transform.Find("MainCamera").right) * -2.0f);
        }
    }
}
