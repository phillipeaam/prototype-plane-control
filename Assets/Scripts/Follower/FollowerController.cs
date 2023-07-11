using Base;
using UnityEngine;

namespace Follower
{
    public class FollowerController : IController
    {
        private readonly IFollower _follower;
        
        public FollowerController(IFollower follower)
        {
            _follower = follower;
        }

        public void Initialize()
        {
            _follower.OnUpdatePosition += UpdatePositionPosition;
            SetRotation();
        }
        
        public void Dispose()
        {
            _follower.OnUpdatePosition -= UpdatePositionPosition;
        }

        #region Implementations

        private void UpdatePositionPosition()
        {
            _follower.SourceTransform.position = _follower.TargetTransform.position + _follower.OffsetPosition;
        }
    
        private void SetRotation()
        {
            _follower.SourceTransform.rotation = Quaternion.Euler(_follower.TargetRotation);
        }

        #endregion
    }
}