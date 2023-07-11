using System;
using UnityEngine;

namespace Follower
{
    public interface IFollower
    {
        public Vector3 OffsetPosition { get; }
        public Vector3 TargetRotation { get; }
        public Transform TargetTransform { get; }
        public Transform SourceTransform { get; }

        public event Action OnUpdatePosition;
    }
}