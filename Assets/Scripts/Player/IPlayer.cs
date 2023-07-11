using System;
using Propeller;
using UnityEngine;

namespace Player
{
    public interface IPlayer
    {
        public IPropeller Propeller { get; }
        public Transform SourceTransform { get; }
        public float Speed { get; }
        public float RotationSpeed { get; }
        public float VerticalInput { get; }

        public event Action OnUpdatePosition;
        public event Action OnCalculateRotation;
    }
}