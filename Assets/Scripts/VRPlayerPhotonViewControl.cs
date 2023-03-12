using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;
using UnityEngine.XR.Interaction.Toolkit;

public class VRPlayerPhotonViewControl : MonoBehaviourPunCallbacks
{
	public GameObject[] toOff;
	public ActionBasedController[] toOff2;
	void Start()
	{
		

		if (!photonView.IsMine)
		{
			foreach (var go in toOff)
			{
				go.SetActive(false);
			}
			foreach (var go in toOff2)
			{
				go.enabled = false;
			}
		}

	}
}
