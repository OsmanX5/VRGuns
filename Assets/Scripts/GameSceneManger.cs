using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameSceneManger : MonoBehaviourPunCallbacks
{
    public override void OnJoinedRoom()
    {
        DebugLog.AddMessege("Welcome  to " + PhotonNetwork.CurrentRoom.Name);
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        DebugLog.AddMessege("Welcome " + newPlayer.NickName);
    }
}
