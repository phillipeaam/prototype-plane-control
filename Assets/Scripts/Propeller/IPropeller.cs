using System;
using UnityEngine;

namespace Propeller
{
    public interface IPropeller
    {
        public float Speed { get; }
        public Transform SourceTransform { get; }
        
        public event Action OnCalculateRotation;
    }
}