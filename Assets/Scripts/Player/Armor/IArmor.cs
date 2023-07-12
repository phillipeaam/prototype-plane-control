using System;
using UnityEngine;

namespace Player.Armor
{
    public interface IArmor
    {
        public event Action<Collision> OnCollision;
    }
}