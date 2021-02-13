using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Animator))]
public class Explosion : MonoBehaviour
{
    [SerializeField] private KnifeSpawner _spawner;
    [SerializeField] private GameObject _explosionPanel;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _spawner.Lose += PlayExplosion;
    }

    private void OnDisable()
    {
        _spawner.Lose -= PlayExplosion;
    }

    private void PlayExplosion()
    {
        _animator.Play("Explosion");
        _explosionPanel.SetActive(true);
    }
}
