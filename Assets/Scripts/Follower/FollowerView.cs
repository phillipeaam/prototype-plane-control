using System;
using UnityEngine;

namespace Follower
{
    public class FollowerView : MonoBehaviour, IFollower
    {
        [SerializeField]
        private Vector3 _offsetPosition;
        public Vector3 OffsetPosition => _offsetPosition;
    
        [SerializeField]
        private Vector3 _targetRotation;
        public Vector3 TargetRotation => _targetRotation;
    
        [SerializeField]
        private Transform _targetTransform;
        public Transform TargetTransform => _targetTransform;
    
        [SerializeField]
        private Transform _sourceTransform;
        public Transform SourceTransform => _sourceTransform;
    
        public event Action OnUpdatePosition;

        private void LateUpdate()
        {
            OnUpdatePosition?.Invoke();
        }
    }
}
