using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed;

    public void GetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Start()
    {
        _speed = GetRandomSpeed();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(_speed * Time.deltaTime * _direction);
    }

    private float GetRandomSpeed()
    {
        float minSpeed = 2f;
        float maxSpeed = 3f;

        return Random.Range( minSpeed, maxSpeed );
    }
}
