using System;
using Propeller;
using UnityEngine;

namespace Player
{
    public class PlayerView : MonoBehaviour, IPlayer
    {
        private const string Vertical = "Vertical";
        
        [SerializeField]
        private PropellerView _propeller;
        public IPropeller Propeller => _propeller;
        
        [SerializeField]
        private Transform _sourceTransform;
        public Transform SourceTransform => _sourceTransform;

        [SerializeField]
        private float _speed;
        public float Speed => _speed;

        [SerializeField]
        private float _rotationSpeed;
        public float RotationSpeed => _rotationSpeed;
        
        public float VerticalInput { get; private set; }

        public event Action OnUpdatePosition;
        public event Action OnCalculateRotation;

        private void Update()
        {
            RegisterInput();
            OnUpdatePosition?.Invoke();
            OnCalculateRotation?.Invoke();
        }

        private void RegisterInput()
        {
            // get the user's vertical input
            VerticalInput = Input.GetAxis(Vertical);
        }
    }
}
