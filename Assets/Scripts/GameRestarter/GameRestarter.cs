using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestarter : MonoBehaviour
{
    [SerializeField] private KnifeSpawner _spawner;

    private void OnEnable()
    {
        _spawner.AllKnifesInTarget += OnLevelComplite;
    }

    private void OnDisable()
    {
        _spawner.AllKnifesInTarget -= OnLevelComplite;
    }

    private void OnLevelComplite()
    {
        StartCoroutine(NextLevelDeleyer());
    }

    private IEnumerator NextLevelDeleyer()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}
