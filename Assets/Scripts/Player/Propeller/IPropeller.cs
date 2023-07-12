using System;
using UnityEngine;

namespace Player.Propeller
{
    public interface IPropeller
    {
        public float Speed { get; }
        public Transform SourceTransform { get; }
        
        public event Action OnCalculateRotation;
    }
}