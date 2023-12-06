using UnityEngine;

public class Target : MonoBehaviour
{
    protected float _speed;

    protected Vector3 _startPosition;
    protected Vector3 _currentPosition;
    protected Vector3 _target;

    protected virtual void ToMove()
    {
        _currentPosition = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }
}
