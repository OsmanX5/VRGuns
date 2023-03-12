using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class PlayerPhotonControl : MonoBehaviourPunCallbacks
{
    public FirstPersonController FirstPersonController;
    public Camera Camera;
    
    void Start()
    {
        
        if (!photonView.IsMine)
        {
            FirstPersonController.enabled = false;
            Camera.enabled = false;
        }

    }

    
}
