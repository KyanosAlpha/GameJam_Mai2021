using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    #region Unity API

    private void OnDrawGizmos()
    {
        _transform = transform;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(_transform.position, _transform.position + _transform.forward * 1);
    }

    private void Awake()
    {
        InitializeOnAwake();
    }

    private void Update()
    {
        SpawningFoods();
    }

    #endregion

    #region Utils

    private void InitializeOnAwake()
    {
        _transform = transform;
        _spawnedFoods = new List<Transform>();
        _spawnTime = Time.time + _nextSpawnTimeMax;
    }

    private void SpawningFoods()
    {
        if (_spawnedFoods.Count < _maxOfSpawn)
        {
            if (Time.time > _spawnTime)
            {
                var waintingToSpawn = Random.Range(_nextSpawnTimeMin, _nextSpawnTimeMax);
                var prefabIndex = Random.Range(0, _foodsList.Count);

                Instantiate(_foodsList[prefabIndex], _transform.position, _transform.rotation);
                _spawnedFoods.Add(_foodsList[prefabIndex]);

                _spawnTime += waintingToSpawn;
            }
        }
    }

    #endregion


    #region Private And Protected

    private Transform _transform;
    [SerializeField]
    private List<Transform> _foodsList;
    private List<Transform> _spawnedFoods;

    private float _spawnTime;
    [SerializeField]
    private float _nextSpawnTimeMin = 0.1f;
    [SerializeField]
    private float _nextSpawnTimeMax = 1f;
    [SerializeField]
    private int _maxOfSpawn = 5;

    #endregion
}