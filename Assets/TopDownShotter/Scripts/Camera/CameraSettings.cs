using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.Camera
{
    [CreateAssetMenu(menuName = "Lesson/Camera/ Camera Settings")]
    public class CameraSettings : ScriptableObject
    {
        [Header("Rotation")]
        [SerializeField] private float _rotationLerpSpeed = 1;
        public float RotationLerpSpeed { get => _rotationLerpSpeed;  }

        [Header("Position")]
        [SerializeField] private Vector3 _positionOffset;
        public Vector3 PositionOffset { get => _positionOffset; }

        [SerializeField] private float _positionLerp;
        public float PositionLerp { get => _positionLerp; }
    }
}