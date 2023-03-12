using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Photon.Pun;

public class VRPlayerPhotonViewControl : MonoBehaviourPunCallbacks
{
	public GameObject XRInteracitonManger;
	public Camera Camera;
	void Start()
	{

		if (!photonView.IsMine)
		{
			XRInteracitonManger.SetActive(false);
			Camera.enabled = false;
		}

	}
}
