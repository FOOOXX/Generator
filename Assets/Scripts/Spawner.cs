using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _spawnPoint;

    private Transform[] _points;
    private float _spawnTime;

    private void Start()
    {
        _spawnTime = 2.0f;

        _points = new Transform[_spawnPoint.childCount];

        for (int i = 0; i < _spawnPoint.childCount; i++)
        {
            _points[i] = _spawnPoint.GetChild(i).transform;
        }

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        WaitForSeconds timer = new(_spawnTime);

        while (true)
        {
            yield return timer;

            CreateEnemy();
        }
    }

    private void CreateEnemy()
    {
        Enemy enemy = Instantiate(_enemy, _points[Random.Range(0, _points.Length)].position, Quaternion.identity);

        enemy.GetDirection(GetRandomDirection());
    }

    private Vector3 GetRandomDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), 0, 0);
    }
}
