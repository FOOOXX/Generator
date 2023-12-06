using UnityEngine;

public class Target : MonoBehaviour
{
    private float _speed;

    private Vector3 _startPosition;
    private Vector3 _currentPosition;
    private Vector3 _target;

    private void Start()
    {
        _speed = 2f;

        _startPosition = transform.position;
        _target = new Vector3(transform.position.x + 6, transform.position.y, transform.position.z);
    }

    private void Update()
    {
        if (transform.position == _target)
        {
            _target = _startPosition;
            _startPosition = _currentPosition;
        }

        Move();
    }

    private void Move()
    {
        _currentPosition = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }
}
