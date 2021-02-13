using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogDestroyer : MonoBehaviour
{
    [SerializeField] private KnifeSpawner _spawner;
    [SerializeField] private DestroyiedLog _destroiedLog;

    private Knife[] _knifes;

    private void OnEnable()
    {
        _spawner.AllKnifesInTarget += OnSucssesfulComplite;
    }

    private void OnDisable()
    {
        _spawner.AllKnifesInTarget -= OnSucssesfulComplite;
    }

    private void OnSucssesfulComplite()
    {
        _knifes = FindObjectsOfType<Knife>();
        foreach (var knife in _knifes)
        {
            knife.transform.parent = null;
            knife.OnLevelComplite();
        }
        DestroyiedLog log = Instantiate(_destroiedLog, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
