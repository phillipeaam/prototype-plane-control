using System;
using UnityEngine;

namespace Player.Armor
{
    public class ArmorView : MonoBehaviour, IArmor
    {
        public event Action<Collision> OnCollision;

        private void OnCollisionEnter(Collision other)
        {
            OnCollision?.Invoke(other);
        }
    }
}