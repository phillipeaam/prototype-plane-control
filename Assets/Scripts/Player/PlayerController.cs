using Base;
using Player.Armor;
using Player.Propeller;
using UnityEngine;

namespace Player
{
    public class PlayerController : IController
    {
        private readonly IPlayer _player;
        private readonly ArmorController _armorController;
        private readonly PropellerController _propellerController;
        
        public PlayerController(IPlayer player)
        {
            _player = player;
            _armorController = new ArmorController(_player.Armor);
            _propellerController = new PropellerController(_player.Propeller);
        }

        public void Initialize()
        {
            _player.OnUpdatePosition += UpdatePosition;
            _player.OnCalculateRotation += CalculateRotation;

            _armorController.Initialize();
            _propellerController.Initialize();
        }

        public void Dispose()
        {
            _player.OnUpdatePosition -= UpdatePosition;
            _player.OnCalculateRotation -= CalculateRotation;

            _armorController.Dispose();
            _propellerController.Dispose();
        }

        #region Implementations

        private void UpdatePosition()
        {
            // move the player forward at a constant rate
            var translationStep = Vector3.forward * (_player.Speed * Time.deltaTime);
            _player.SourceTransform.Translate(translationStep);
        }
        
        private void CalculateRotation()
        {
            // don't rotate if there is no input
            if (_player.VerticalInput == 0) 
                return;
            
            // tilt the plane up/down based on up/down arrow keys
            var rotationStep = Vector3.right * (_player.VerticalInput * _player.RotationSpeed * Time.deltaTime);
            _player.SourceTransform.Rotate(rotationStep);
        }

        #endregion
    }
}