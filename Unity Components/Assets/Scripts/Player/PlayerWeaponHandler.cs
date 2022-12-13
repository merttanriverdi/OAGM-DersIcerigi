using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeaponHandler : MonoBehaviour
{
    public GameObject bulletPrefab;
    
    private GameObject _bulletSpawnPoint;

    private void Awake()
    {
        _bulletSpawnPoint = GameObject.FindGameObjectWithTag("BulletSpawnPoint");
    }

    public void OnFire(InputValue inputValue)
    {
        GameObject bulletObj = Instantiate(bulletPrefab, _bulletSpawnPoint.transform.position, Quaternion.identity);
        bulletObj.GetComponent<Bullet>().Shoot(_bulletSpawnPoint.transform.forward);
    }
}
