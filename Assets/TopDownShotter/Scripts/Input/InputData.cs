using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.UserInput
{
    [CreateAssetMenu(menuName = "Lesson/Input/ Input Data Settings")]
    public class InputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
    }
}