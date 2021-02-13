using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private KnifeSpawner _spawner;
    [SerializeField] private GameObject _panel;

    private void OnEnable()
    {
        _spawner.Lose += ActivatePanel;
    }

    private void OnDisable()
    {
        _spawner.Lose -= ActivatePanel;
    }

    private void ActivatePanel()
    {
        StartCoroutine(Deley());
    }

    private IEnumerator Deley()
    {
        yield return new WaitForSeconds(0.5f);
        _panel.SetActive(true);
    }
}
