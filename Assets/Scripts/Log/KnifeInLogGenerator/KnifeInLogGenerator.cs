using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInLogGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] _points;
    [SerializeField] private GameObject _knifeTemplate;

    private void Start()
    {
        GenerateKnifes();
    }

    private void GenerateKnifes()
    {
        int randomKnifesCount = Random.Range(0, 4);
        for (int i = 0; i < randomKnifesCount; i++)
        {
            Knife knife = Instantiate(_knifeTemplate, _points[i].transform.position, _points[i].transform.rotation, _points[i].transform).GetComponent<Knife>();
        }
    }
}
