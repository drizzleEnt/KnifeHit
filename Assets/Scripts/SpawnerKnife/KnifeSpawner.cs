using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Singlton;

public class KnifeSpawner : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private GameObject _knifeTemplate;
    [SerializeField] private int _knifeCount;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Transform _startpoint;

    private Knife _currentKnife;

    public event UnityAction<int> KnifeCountChaged;
    public event UnityAction AllKnifesInTarget;
    public event UnityAction KnifeInLog;
    public event UnityAction Lose;
    
    private void Start()
    {
        SpawnKnife();
    }

    private void OnEnable()
    {
        KnifeCountChaged?.Invoke(_knifeCount);
    }

    private void SpawnKnife()
    {
        if(_currentKnife == null)
            InstantiateKnife();
    }

    private void InstantiateKnife()
    {
        Knife knife = Instantiate(_knifeTemplate, _spawnPoint.position, _spawnPoint.rotation, _spawnPoint).GetComponent<Knife>();
        _currentKnife = knife;
        knife.SetStartPosition(_startpoint.position);
        knife.RanIntoKnife += OnRunningIntoKnife;
        knife.RanIntoLog += OnLogEnter;
        knife.RanIntoApple += OnAppleEnter;
    }

    private void OnRunningIntoKnife(Knife knife)
    {
        _knifeCount--;
        knife.RanIntoApple -= OnAppleEnter;
        knife.RanIntoKnife -= OnRunningIntoKnife;
        knife.RanIntoKnife -= OnLogEnter;
        knife.RanIntoApple -= OnAppleEnter;
        Lose?.Invoke();
    }

    private void OnLogEnter(Knife knife)
    {
        KnifeInLog?.Invoke();
        _knifeCount--;
        _player.IncreaseScore();
        KnifeCountChaged?.Invoke(_knifeCount);
        knife.RanIntoKnife -= OnRunningIntoKnife;
        knife.RanIntoKnife -= OnLogEnter;
        if (_knifeCount == 0)
        {
            AllKnifesInTarget?.Invoke();
            return;
        }
        ResetKnife();
    }

    private void OnAppleEnter()
    {
        _player.IncreaseAppleCount();
    }

    private void ResetKnife()
    {
        _currentKnife = null;
        SpawnKnife();
    }
}
