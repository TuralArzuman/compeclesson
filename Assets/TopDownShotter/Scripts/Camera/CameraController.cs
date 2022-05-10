using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private Transform _cameraTransform;
        [SerializeField] private Transform _targetTransform;

        private void Update()
        {
            CameraRotationController();
            CameraMovementFollow();
        }

        void CameraRotationController()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation,
                Quaternion.LookRotation(_targetTransform.position - _cameraTransform.position),
                _cameraSettings.RotationLerpSpeed * Time.deltaTime);
        }

        void CameraMovementFollow()
        {
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position,
                _targetTransform.position + _cameraSettings.PositionOffset,
                Time.deltaTime * _cameraSettings.PositionLerp);


        }
    }
}