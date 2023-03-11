using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class PlayerPhotonControl : MonoBehaviourPunCallbacks
{
    public FirstPersonController FirstPersonController;
    public Camera Camera;
    public TMP_Text nameTMP;
    void Start()
    {
        
        if (!photonView.IsMine)
        {
            FirstPersonController.enabled = false;
            Camera.enabled = false;
        }
        else
        {
            nameTMP.text = PhotonNetwork.NickName;
        }
    }

    
}
