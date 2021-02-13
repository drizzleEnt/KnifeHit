using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogRotator : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _deleyBetweenChanging;

    private float _elapsedTime;
    private float _currentSpeed;

    private void Awake()
    {
        _currentSpeed = _rotationSpeed;
    }

    private void FixedUpdate()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _deleyBetweenChanging)
        {
            float randomSpeed = Random.Range(-3, 3.5f);
            _currentSpeed = 1;
            _currentSpeed *= randomSpeed;
            _elapsedTime = 0;
        }
        _rotationSpeed = Mathf.Lerp(_rotationSpeed, _currentSpeed, Time.deltaTime);
        transform.Rotate(0, 0, _rotationSpeed);
    }
}
