using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform teleportTarget;  // The target position to teleport the player to

    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Move the player to the teleport target position
            other.transform.position = teleportTarget.position;
        }
    }
}
