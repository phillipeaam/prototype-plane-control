using System;
using Player.Armor;
using Player.Propeller;
using UnityEngine;

namespace Player
{
    public interface IPlayer
    {
        public IArmor Armor { get; }
        public IPropeller Propeller { get; }
        public Transform SourceTransform { get; }
        public float Speed { get; }
        public float RotationSpeed { get; }
        public float VerticalInput { get; }

        public event Action OnUpdatePosition;
        public event Action OnCalculateRotation;
    }
}