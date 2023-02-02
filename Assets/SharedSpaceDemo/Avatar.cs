using System;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.Animations;

#define OCUL

namespace SharedSpaceDemo
{
	public class Avatar : NetworkBehaviour
	{
		[SerializeField] private Transform _avatarHead;
		private Transform _headTarget;

		private void Start()
		{
			if (IsOwner)
			{
				OVRCameraRig oculusRig = FindObjectOfType<OVRCameraRig>();
				oculusRig.
			}
		}

		private void Update()
		{
			_avatarHead.position = OVRInput.GetLocalControllerPosition(OVRInput.Controller.LTouch);
		}
	}
}