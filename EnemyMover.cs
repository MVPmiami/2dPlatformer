using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _path;
    [SerializeField] private int _startPoint;
    [SerializeField] private float _localScale;

    private Transform[] _points;
    private int _currentPoint;

    private void Start()
    {
        _currentPoint = _startPoint - 1;
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
            _points[i] = _path.GetChild(i);
    }


    private void Update()
    {
        Transform target = _points[_currentPoint];
        
        transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (_currentPoint != 0)
            transform.localScale = new Vector2(_localScale, _localScale);
        else if (_currentPoint == 0)
            transform.localScale = new Vector2(-_localScale, _localScale);

        if (transform.position.x == target.position.x)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
                _currentPoint = 0;
        }
    }
}
