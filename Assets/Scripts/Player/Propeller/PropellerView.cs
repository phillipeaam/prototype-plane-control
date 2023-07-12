using System;
using UnityEngine;

namespace Player.Propeller
{
    public class PropellerView : MonoBehaviour, IPropeller
    {
        [SerializeField]
        private float _speed;
        public float Speed => _speed;
        
        [SerializeField]
        private Transform _sourceTransform;
        public Transform SourceTransform => _sourceTransform;
        
        public event Action OnCalculateRotation;
        
        private void LateUpdate()
        {
            OnCalculateRotation?.Invoke();
        }
    }
}