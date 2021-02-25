using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodParticalsActivator : MonoBehaviour
{
    [SerializeField] private ParticleSystem _woodParticls;
    [SerializeField] private KnifeSpawner _spawner;

    private void OnEnable()
    {
        _spawner.KnifeInLog += PlayWoodParticals;
    }

    private void OnDisable()
    {
        _spawner.KnifeInLog -= PlayWoodParticals;
    }

    private void PlayWoodParticals()
    {
        _woodParticls.Play();
    }

}
