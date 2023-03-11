using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class GameSceneManger : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject PlayerPrefab;
    public void Start()
    {
        DebugLog.AddMessege("Welcome  to " + PhotonNetwork.CurrentRoom.Name);
        PhotonNetwork.Instantiate(PlayerPrefab.name,Vector3.zero,Quaternion.identity);
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        DebugLog.AddMessege("Welcome " + newPlayer.NickName);
    }
}
