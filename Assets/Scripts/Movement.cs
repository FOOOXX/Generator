using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] [Range(1, 5)] private float _speed;

    private Transform _target;

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
}
