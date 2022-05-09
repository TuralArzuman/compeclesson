using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson
{
    [CreateAssetMenu(menuName="Lesson/Lesson1/ Rotate Object")]
    public class RotateSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 1;

        public float Speed { get { return _speed; } }
    }
}