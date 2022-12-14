using System;
using System.Collections;
using System.Collections.Generic;
using Managers;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
   [Header("Prefab References")]
   public GameObject easyPrefab;
   public GameObject mediumPrefab;
   public GameObject hardPrefab;

   [Header("Spawn References")]
   [Range(1,4)] public int spawnCount = 3;
   public Transform spawnPointsParent;

   private List<Transform> _spawnPoints;

   private void Awake()
   {
      SetupSpawnPoints();
      InitializeEnemies();
   }

   private void OnEnable()
   {
      EventManager.OnEnemyDeadAction += OnEnemyDead;
   }

   private void OnDisable()
   {
      EventManager.OnEnemyDeadAction -= OnEnemyDead;
   }

   private void OnEnemyDead(EnemyType targetType)
   {
      SpawnEnemy(targetType);
   }

   private void InitializeEnemies()
   {
      for (int i = 0; i < spawnCount; i++)
      {
         SpawnEnemy((EnemyType)(i%3));
      }
   }

   private void SetupSpawnPoints()
   {
      _spawnPoints = new List<Transform>();

      for (int i = 0; i < spawnPointsParent.childCount; i++)
      {
         _spawnPoints.Add(spawnPointsParent.GetChild(i));
      }
   }

   private void SpawnEnemy(EnemyType targetType)
   {
      GameObject enemyToSpawn;
      
      switch (targetType)
      {
         case EnemyType.Easy:
            enemyToSpawn = easyPrefab;
            break;
         case EnemyType.Medium:
            enemyToSpawn = mediumPrefab;
            break;
         case EnemyType.Hard:
            enemyToSpawn = hardPrefab;
            break;
         default:
            enemyToSpawn = easyPrefab;
            break;
      }

      Transform selectedSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];

      while (selectedSpawnPoint.childCount > 0)
      {
         selectedSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
      }
      
      Instantiate(enemyToSpawn, selectedSpawnPoint.position, Quaternion.Euler(0,180f,0),selectedSpawnPoint);
   }
   
   
}
