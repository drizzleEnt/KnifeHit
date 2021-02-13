using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibrator : MonoBehaviour
{
    [SerializeField] private KnifeSpawner _spawner;

    private void OnEnable()
    {
        _spawner.Lose += OnVibration;
    }

    private void OnDisable()
    {
        _spawner.Lose -= OnVibration;
    }

    private void OnVibration()
    {
        Handheld.Vibrate();
    }
}
