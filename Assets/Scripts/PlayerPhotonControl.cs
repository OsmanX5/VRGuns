using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerPhotonControl : MonoBehaviourPunCallbacks
{
    public FirstPersonController FirstPersonController;
    public XRController Camera;
    
    void Start()
    {
        
        if (!photonView.IsMine)
        {
            FirstPersonController.enabled = false;
            Camera.enabled = false;
        }

    }

    
}
