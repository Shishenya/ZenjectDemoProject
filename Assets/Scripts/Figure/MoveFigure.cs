using UnityEngine;

public class MoveFigure : MonoBehaviour
{
    private readonly float _yMin = -9f;
    private readonly float _speed = 5f;
    private float _minDistance = 0.3f;

    private Vector3 _targetVector;

    private void Start()
    {
        _targetVector = new Vector3(transform.position.x, _yMin, 0f);
    }

    void Update()
    {
        transform.position =  Vector3.MoveTowards(transform.position, _targetVector, _speed * Time.deltaTime);

        if (CheckDistance()) Destroy(gameObject);
    }

    private bool CheckDistance() {
        if (Vector3.Distance(transform.position, _targetVector) < _minDistance) return true;
        return false;
    }

}
