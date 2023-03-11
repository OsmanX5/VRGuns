using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Unity.VisualScripting;
using Photon.Realtime;

public class ConnectionManger : MonoBehaviourPunCallbacks
{
    public GameObject EnterNamePanel;
    public GameObject ConnectingPanel;
    public GameObject LoobiesPanel;
    public TMP_InputField nameField;
    PhotonConnectingManger manger;
    private void Start()
    {
        EnterNamePanel.SetActive(true);
        ConnectingPanel.SetActive(false);
        LoobiesPanel.SetActive(false);
        manger = this.AddComponent<PhotonConnectingManger>();
    }
    public void OnCLick_ConnectToServer()
    {
        EnterNamePanel.SetActive(false);
        ConnectingPanel.SetActive(true);
        Debug.Log("COnnnecting to server");
        PhotonNetwork.NickName = nameField.text;
        manger.EnterTheServer();
    }
    public void OnClick_JoinRoom()
    {
        manger.JoinRoom();
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log(PhotonNetwork.NickName + "Connected to master");
        ConnectingPanel.SetActive(false);
        LoobiesPanel.SetActive(true);
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        EnterNamePanel.SetActive(true);
        ConnectingPanel.SetActive(false);
        LoobiesPanel.SetActive(false);
        Debug.Log(cause);
    }

}
