using Base;
using UnityEngine;

namespace Player.Propeller
{
    public class PropellerController : IController
    {
        private readonly IPropeller _propeller;
        
        public PropellerController(IPropeller propeller)
        {
            _propeller = propeller;
        }

        public void Initialize()
        {
            _propeller.OnCalculateRotation += CalculateRotation;
        }

        public void Dispose()
        {
            _propeller.OnCalculateRotation -= CalculateRotation;
        }

        #region Implementations

        private void CalculateRotation()
        {
            _propeller.SourceTransform.Rotate(Vector3.forward, _propeller.Speed * Time.deltaTime);
        }

        #endregion
    }
}