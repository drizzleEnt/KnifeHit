using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDestroied : MonoBehaviour
{
    private float _lifeTime = 1.5f;

    private void Start()
    {
        Destroy(gameObject, _lifeTime);
    }
}
