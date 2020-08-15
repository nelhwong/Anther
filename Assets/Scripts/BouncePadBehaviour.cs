using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncePadBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionStay(Collision collision)
    {
        collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.contacts[0].normal * 50f, ForceMode.Impulse);
    }
}
