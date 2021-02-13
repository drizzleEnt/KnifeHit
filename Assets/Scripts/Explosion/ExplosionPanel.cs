using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPanel : MonoBehaviour
{
    [SerializeField] private float _showTime;

    private void OnEnable()
    {
        StartCoroutine(Showing());
    }

    private IEnumerator Showing()
    {
        yield return new WaitForSeconds(_showTime);
        gameObject.SetActive(false);
    }
}
