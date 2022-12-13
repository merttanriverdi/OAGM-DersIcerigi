#region Header

// PlayerCollisionController.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com

#endregion

using System;
using Interfaces;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICollectible collectible))
        {
            
            collectible.Collect();
        }
    }
}