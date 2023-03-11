using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

public class PhotonConnectingManger : MonoBehaviourPunCallbacks
{
    #region Public Functions
    public void EnterTheServer()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    #endregion


}
