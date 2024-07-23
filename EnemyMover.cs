using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _pathPoints;
    [SerializeField] private int _startPoint;
    [SerializeField] private float _localScale;

    private int _currentPoint;

    private void Start()
    {
        _currentPoint = _startPoint - 1;
    }

    private void FixedUpdate()
    {
        Move();
        ChangeViewDirection();
    }

    private void Move()
    {
        Transform target = _pathPoints[_currentPoint];

        transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position.x == target.position.x)
            _currentPoint = ++_currentPoint % _pathPoints.Length;
    }

    private void ChangeViewDirection()
    {
        if (_currentPoint != 0)
            transform.localScale = new Vector2(_localScale, _localScale);
        else if (_currentPoint == 0)
            transform.localScale = new Vector2(-_localScale, _localScale);
    }
}
