using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private Transform _spawnPoint;
    private Transform[] _points;
    private Vector3 _direction;

    private float _spawnTime;
    private float _duration;

    private void Start()
    {
        _spawnPoint = GetComponent<Transform>();

        _points = new Transform[_spawnPoint.childCount];

        for (int i = 0; i < _spawnPoint.childCount; i++)
        {
            _points[i] = _spawnPoint.GetChild(i);
        }

        _spawnTime = 2.0f;
        _duration = _spawnTime;
    }

    private void Update()
    {
        _direction = GetRandomDirection();

        if(_duration <= 0)
        {
            CreateClones();
        }
        else
        {
            _duration -= Time.deltaTime;
        }
    }

    private void CreateClones()
    {
        Enemy enemy = Instantiate(_enemy, _points[Random.Range(0, _points.Length)].position, Quaternion.identity);

        enemy.GetDirection(_direction);

        _duration = _spawnTime;
    }

    private Vector3 GetRandomDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), 0, 0);
    }
}
