using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Apple : MonoBehaviour
{
    [SerializeField] private AppleDestroied _destroidApple;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AppleDestroied apple = Instantiate(_destroidApple, transform.position, Quaternion.identity);
        gameObject.SetActive(false);
    }
}
