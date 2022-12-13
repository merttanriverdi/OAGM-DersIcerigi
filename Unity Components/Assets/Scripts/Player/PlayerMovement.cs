#region Header
// PlayerMovement.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com
#endregion

using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Range(0,15)] public float speed = 5;

        private Vector3 _movementVector;
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        public void OnMove(InputValue inputValue)
        {
            Vector2 value = inputValue.Get<Vector2>();
            _movementVector = new Vector3(value.x,0,value.y);
        }

        private void FixedUpdate()
        {
            //_rb.AddForce(_movementVector * speed);
            _rb.velocity = _movementVector * speed;
        }
    }
}