using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private PlayerMovementSettings _playerSettings;
        [SerializeField] private Rigidbody _rigidbody;
        private void Awake() => _rigidbody = GetComponent<Rigidbody>(); 
        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.right * _inputData.Horizontal * _playerSettings.HorizontalSpeed1)); 
            _rigidbody.MovePosition(_rigidbody.position+(_rigidbody.transform.forward * _inputData.Vertical * _playerSettings.VerticalSpeed1));
        }
    }
}