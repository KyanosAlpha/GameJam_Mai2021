using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    #region Unity API

    private void OnDrawGizmos()
    {
        _transform = transform;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(_transform.position, _transform.forward);
    }

    private void Awake()
    {
        _transform = transform;
        _spawnTime = Time.time + _nextSpawnTime;
    }

    private void Update()
    {
        if(Time.time > _spawnTime)
        {
            int prefabIndex = Random.Range(0, _foodsList.Count);
            Instantiate(_foodsList[prefabIndex], _transform.position, _transform.rotation);

            _spawnTime += _nextSpawnTime;
        }
        
    }

    #endregion


    #region Private And Protected

    private Transform _transform;

    [SerializeField]
    private List<Transform> _foodsList;

    private float _spawnTime;
    [SerializeField]
    private float _nextSpawnTime = 2f;

    #endregion
}