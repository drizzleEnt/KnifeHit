using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGenerator : MonoBehaviour
{
    [SerializeField] private AppleScriptableObject _appleObject;
    [SerializeField] private Apple _template;
    [SerializeField] private Transform _spawnPoint;

    private float _chance;

    private void Start()
    {
        _chance = _appleObject.Chacne;
        float randomNumber = Random.Range(0f, 1f);
        if (randomNumber <= _chance)
        {
            Apple newApple = Instantiate(_template, _spawnPoint.position, _spawnPoint.rotation, _spawnPoint);
        }  
    }
}
