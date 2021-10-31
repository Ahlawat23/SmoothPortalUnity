using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Camera teleporterCam_B;
    public Material camMat_A;

    public Camera teleporterCam_A;
    public Material camMat_B;

    // Start is called before the first frame update
    void Start()
    {
        if(teleporterCam_B.targetTexture != null)
        {
            teleporterCam_B.targetTexture.Release();
        }

        teleporterCam_B.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camMat_A.mainTexture = teleporterCam_B.targetTexture;

        if (teleporterCam_A.targetTexture != null)
        {
            teleporterCam_A.targetTexture.Release();
        }

        teleporterCam_A.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        camMat_B.mainTexture = teleporterCam_A.targetTexture;

    }

    
}
