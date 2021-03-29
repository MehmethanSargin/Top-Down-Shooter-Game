using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]
        private CameraSettings cameraSettings;
        [SerializeField]
        private Transform targetTransform;
        [SerializeField] 
        private Transform cameraTransform;

        private void Update()
        {
            CameraMovementFollow();
            CameraRotationFollow();
        }

        private void CameraRotationFollow()
        {
            cameraTransform.rotation = Quaternion.Lerp(cameraTransform.rotation, Quaternion.LookRotation
            (targetTransform.position - cameraTransform.position), Time.deltaTime * cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            cameraTransform.position = Vector3.Lerp(cameraTransform.position, targetTransform.position +
            cameraSettings.PositionOffset, Time.deltaTime * cameraSettings.PositionLerp);
        }
    }
}

