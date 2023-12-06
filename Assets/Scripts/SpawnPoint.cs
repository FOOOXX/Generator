using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _target;

    public Enemy GetEnemy()
    {
        return _enemy;
    }

    public Transform GetTarget()
    {
        return _target;
    }
}
