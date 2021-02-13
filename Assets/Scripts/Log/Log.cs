using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Log : MonoBehaviour
{
    [SerializeField] private KnifeSpawner _spawner;
    [SerializeField] private LogAnimator _logAnimator;

    private CircleCollider2D _collider;

    private void Start()
    {
        _collider = GetComponent<CircleCollider2D>();
    }

    private void OnEnable()
    {
        _spawner.AllKnifesInTarget += Destroy;
        _spawner.KnifeInLog += StartHitAnimation;
        _spawner.Lose += StartHitAnimation;
    }

    private void OnDisable()
    {
        _spawner.AllKnifesInTarget -= Destroy;
        _spawner.KnifeInLog -= StartHitAnimation;
        _spawner.Lose -= StartHitAnimation;
    }

    private void Destroy()
    {
        _collider.enabled = false;
    }

    private void StartHitAnimation()
    {
        _logAnimator.PlayHitAnimation();
    }
}
