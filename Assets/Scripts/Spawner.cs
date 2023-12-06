using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _points;

    private WaitForSeconds _timer;
    private float _spawnTime;

    private void Start()
    {
        _spawnTime = 2.0f;

        _timer = new WaitForSeconds(_spawnTime);

        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return _timer;

            CreateEnemy();
        }
    }

    private void CreateEnemy()
    {
        for (int i = 0; i < _points.Length; i++)
        {
            Enemy enemy = Instantiate(_points[i].GetEnemy(), _points[i].transform.position, Quaternion.identity);

            enemy.SetDirection(_points[i].GetTarget());
        }
    }
}
