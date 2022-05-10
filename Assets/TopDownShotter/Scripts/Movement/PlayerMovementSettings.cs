using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerMovement {
    [CreateAssetMenu(menuName = "Lesson/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [SerializeField] private float HorizontalSpeed = 5;
        [SerializeField] private float VerticalSpeed = 5;

        public float HorizontalSpeed1 { get => HorizontalSpeed; }
        public float VerticalSpeed1 { get => VerticalSpeed; }
    }
}