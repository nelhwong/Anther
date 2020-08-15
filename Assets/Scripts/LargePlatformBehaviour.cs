using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargePlatformBehaviour : MonoBehaviour
{
    // Maximium horizontal motion
    public float rangeOfMotion = 10.0f;

    // The incrementing number indicating
    private float periodOfMotion = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().AddForce(new Vector3(Mathf.Sin(periodOfMotion * (180/Mathf.PI)) * rangeOfMotion, 0, 0));
        //transform.Translate(new Vector3(Mathf.Sin(periodOfMotion) * rangeOfMotion, 0, 0));
        transform.Translate(new Vector3(rangeOfMotion, 0, 0));
        periodOfMotion++;
    }
}
