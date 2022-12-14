#region Header
// EventManager.cs
// Developed by Taygun Savaş
// taygun.savas@triflesgames.com
#endregion

using System;
using UnityEngine.Events;

namespace Managers
{
    public static class EventManager
    {
        public static UnityAction<EnemyType> OnEnemyDeadAction;
    }
}