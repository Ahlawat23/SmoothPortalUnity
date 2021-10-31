using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporterCamMovement : MonoBehaviour
{

    public Transform playerCamera;
    public Transform portal;
    public Transform otherPortal;

    

    // Update is called once per frame
    void Update()
    {
        Vector3 playerOffset = playerCamera.position - otherPortal.position;
        transform.position = portal.position + playerOffset;

        float angularDiffBetweenPortals = Quaternion.Angle(portal.rotation, otherPortal.rotation);
        Quaternion portalRoatationDiffrence = Quaternion.AngleAxis(angularDiffBetweenPortals, Vector3.up);

        Vector3 newCameraDirection = portalRoatationDiffrence * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up); 
        
    }
}
