#region Header
// Bullet.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com
#endregion

using System;
using UnityEngine;

    public class Bullet : MonoBehaviour
    {
        public float initialVelocity;
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        public void Shoot(Vector3 forward)
        {
            _rb.AddForce(forward * initialVelocity,ForceMode.VelocityChange);
        }
    }
