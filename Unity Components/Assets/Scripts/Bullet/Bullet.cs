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

        public int damage = 50;
        
        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void OnTriggerEnter(Collider other)
        {
            //Debug.Log("Bullet hit " + other.name);

            if (other.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Bullet hit " + other.name);
                other.GetComponent<EnemyController>().TakeDamage(damage);
                Destroy(gameObject);
            }
        }

        public void Shoot(Vector3 forward)
        {
            _rb.AddForce(forward * initialVelocity,ForceMode.VelocityChange);
        }
    }
