using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Movement _enemy;
    [SerializeField] private Transform _target;

    public Movement GetEnemy()
    {
        return _enemy;
    }

    public Transform GetTarget()
    {
        return _target;
    }
}
