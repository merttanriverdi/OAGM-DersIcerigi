#region Header
// IInputHandler.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com
#endregion

using System;
using UnityEngine;

public interface IInputHandler
{
    Action<Vector3> OnInputHandled { get; set; }

    void Move(Vector3 direction);
}