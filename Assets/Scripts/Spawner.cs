using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy[] _enemies;
    [SerializeField] private GameObject[] _targets;
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
        for (int i = 0; i < _points.Length; i++)
        {
            Enemy enemy = Instantiate(_enemies[i], _points[i].position, Quaternion.identity);

            enemy.SetDirection(_targets[i].transform);
        }
    }
}
