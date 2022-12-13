#region Header
// AiInputHandler.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com
#endregion

using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Ai
{
    public class AiInputHandler : MonoBehaviour,IInputHandler
    {
        public Action<Vector3> OnInputHandled { get; set; }

        private void Update()
        {
            Vector3 randomDirection = Random.insideUnitCircle;
            randomDirection.z = randomDirection.y;
            randomDirection.y = 0;
            Move(randomDirection);
        }

        public void Move(Vector3 direction)
        {
            OnInputHandled?.Invoke(direction);
        }
    }
}