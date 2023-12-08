using UnityEngine;

[RequireComponent (typeof(Movement))]

public class Direction : MonoBehaviour
{
    [SerializeField] private Transform _path;

    private Transform[] _points;
    private Transform _target;
    private Movement _movement;

    private int _currentPoint;

    private void Start()
    {
        _movement = GetComponent <Movement>();

        SetPoints();

        _target = _points[_currentPoint];
    }

    private void Update()
    {
        _movement.SetDirection(_target);

        if (transform.position != _target.position)
            return;

        SetNextTarget();
    }

    private void SetPoints()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void SetNextTarget()
    {
        _currentPoint++;

        if (_currentPoint >= _points.Length)
        {
            _currentPoint = 0;
        }

        _target = _points[_currentPoint];
    }
}
