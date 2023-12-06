using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform _target;
    private float _speed;

    private void Start()
    {
        _speed = GetRandomSpeed();
    }

    private void Update()
    {
        Move();
    }

    public void SetDirection(Transform target)
    {
        _target = target;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    private float GetRandomSpeed()
    {
        float minSpeed = 1f;
        float maxSpeed = 1.5f;

        return Random.Range(minSpeed, maxSpeed);
    }
}
