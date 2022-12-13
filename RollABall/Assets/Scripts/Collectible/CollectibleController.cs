#region Header
// CollectibleController.cs
// Developed by Taygun Savas
// taygun.savas@triflesgames.com
#endregion

using Interfaces;
using UnityEngine;

namespace Collectible
{
    public class CollectibleController : MonoBehaviour,ICollectible
    {
        public int score = 10;
        
        public void Collect()
        {
            GameManager.instance.SetScore(score);
            gameObject.SetActive(false);
        }
    }
}