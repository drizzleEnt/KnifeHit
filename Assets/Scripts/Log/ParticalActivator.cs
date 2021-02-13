using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalActivator : MonoBehaviour
{
    [SerializeField] private ParticleSystem _explosionParticls;
    [SerializeField] private KnifeSpawner _spawner;

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
        _explosionParticls.Play();
    }
}
