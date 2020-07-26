using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// When the player falls off the platform, you respawn
public class levelDeath : MonoBehaviour
{
    /*
  void onTriggerEnter()
    {
        SceneManager.LoadScene(0);
    }
    */
    
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void onTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();
        }
    }
    
}
