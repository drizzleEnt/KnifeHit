using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeCountShower : MonoBehaviour
{
    [SerializeField] private Image[] _knifeImages;
    [SerializeField] private Sprite _fullKnife;
    [SerializeField] private Sprite _emptyKnife;
    [SerializeField] private KnifeSpawner _spawner;

    private void OnEnable()
    {
        _spawner.KnifeCountChaged += OnKnifeCountChanged;
    }

    private void OnDisable()
    {
        _spawner.KnifeCountChaged -= OnKnifeCountChanged;
    }

    private void OnKnifeCountChanged(int currentCount)
    {
        for (int i = 0; i < _knifeImages.Length; i++)
        {
            if (i < currentCount)
                _knifeImages[i].sprite = _fullKnife;
            else
                _knifeImages[i].sprite = _emptyKnife;
        }
    }
}
