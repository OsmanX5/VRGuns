using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Unity.VisualScripting;

public class ConnectionManger : MonoBehaviour
{
    public TMP_InputField nameField;
    PhotonConnectingManger manger;
    private void Start()
    {
        manger = this.AddComponent<PhotonConnectingManger>();
    }
    public void OnCLick_ConnectToServer()
    {
        Debug.Log("COnnnecting to server");
        PhotonNetwork.NickName = nameField.text;
        manger.EnterTheServer();
    }
}
