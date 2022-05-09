using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson
{
    [CreateAssetMenu(menuName = "Lesson/Lesson1/ Control Rigidbody Settings")]
    public class RigidbodySettings : ScriptableObject
    {
        [SerializeField] private Vector3 _jumpForce;

        public Vector3 JumpForce { get => _jumpForce; }
    }
}
