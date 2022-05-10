using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson
{
    public class RotateObject : MonoBehaviour
    {
        [SerializeField] private float _speed = 1;
        [SerializeField] private RotateSettings _rotateSettings;

        private void Update()
        {
            transform.Rotate(Vector3.up * _rotateSettings.Speed * Time.deltaTime);
        }
    }
}
