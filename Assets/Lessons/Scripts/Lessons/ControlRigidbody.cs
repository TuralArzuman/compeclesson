using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private RigidbodySettings _settings;

        private void Awake() => _rigidbody = GetComponent<Rigidbody>();

        private void Update() 
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody.AddForce(_settings.JumpForce, ForceMode.Impulse);
            }
        }

    }
}
