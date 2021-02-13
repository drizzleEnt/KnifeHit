using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeParticalsActivator : MonoBehaviour
{
    [SerializeField] private ParticleSystem _woodParticls;
    [SerializeField] private Knife _knife;

    private void OnEnable()
    {
        _knife.RanIntoLog += PlayWoodParticals;
    }

    private void OnDisable()
    {
        _knife.RanIntoLog -= PlayWoodParticals;
    }

    private void PlayWoodParticals(Knife knife)
    {
        _woodParticls.Play();
    }

}
