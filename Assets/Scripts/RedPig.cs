using UnityEngine;

public class RedPig : Target
{
    private void Start()
    {
        _speed = 3f;

        _startPosition = transform.position;
        _target = new Vector3(transform.position.x + 6, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        if (transform.position != _target)
        {
            ToMove();
        }
        else
        {
            _target = _startPosition;
            _startPosition = _currentPosition;

            ToMove();
        }
    }
}