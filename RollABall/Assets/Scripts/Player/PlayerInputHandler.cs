#region Header

// PlayerInputHandler.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com

#endregion

using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerInputHandler : MonoBehaviour, IInputHandler
    {
        public Action<Vector3> OnInputHandled { get; set; }

        public void OnMove(InputValue action)
        {
            Vector2 direction = action.Get<Vector2>();
            Move(new Vector3(direction.x, 0f, direction.y));
        }

        public void Move(Vector3 direction)
        {
            OnInputHandled?.Invoke(direction);
        }
    }
}