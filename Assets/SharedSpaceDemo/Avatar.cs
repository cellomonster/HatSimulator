#define OCUL

using System;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.Animations;
using UnityEngine.XR;
using UnityEngine.XR.OpenXR.Input;

namespace SharedSpaceDemo
{
	public class Avatar : MonoBehaviour
	{
		[SerializeField] private Transform _head;
		[SerializeField] private Transform _leftHand;
		[SerializeField] private Transform _rightHand;

		private InputDevice _headDevice;
		private InputDevice _leftHandDevice;
		private InputDevice _rightHandDevice;

		private void Start()
		{
			_headDevice = InputDevices.GetDeviceAtXRNode(XRNode.Head);
			_leftHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
			_rightHandDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
		}

		private void Update()
		{
			_headDevice.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 headPosition);
			_headDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion headRotation);
			_head.position = headPosition;
			_head.rotation = headRotation;

			_leftHandDevice.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 leftHandPosition);
			_leftHandDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion leftHandRotation);
			_leftHand.position = leftHandPosition;
			_leftHand.rotation = leftHandRotation;

			_rightHandDevice.TryGetFeatureValue(CommonUsages.devicePosition, out Vector3 rightHandPosition);
			_rightHandDevice.TryGetFeatureValue(CommonUsages.deviceRotation, out Quaternion rightHandRotation);
			_rightHand.position = rightHandPosition;
			_rightHand.rotation = rightHandRotation;
		}
	}
}