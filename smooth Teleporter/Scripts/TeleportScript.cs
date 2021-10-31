using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    public Transform player;
    public Transform reciever;

    public bool isPlayerOverlapped = false;

    private void Update()
    {
        if (isPlayerOverlapped)
        {
            Vector3 portalToPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.forward, portalToPlayer);


            // If this is true: The player has moved across the portal
            if (dotProduct < 0f)
            {
                // Teleport him!
                float rotationDiff = -Quaternion.Angle(transform.rotation, reciever.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portalToPlayer;
                player.position = reciever.position + positionOffset;

                isPlayerOverlapped = false;
            }
        }
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerOverlapped = true;
        }
        
    }

     void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isPlayerOverlapped = false;
        }

    }
}
