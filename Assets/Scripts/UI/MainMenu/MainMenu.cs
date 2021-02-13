using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text _appleText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _stageText;


    private void Awake()
    {
        StatsSaver saver = new StatsSaver();
        _appleText.text = saver.AppleCount.ToString();
        _scoreText.text = saver.MaxScore.ToString();
        _stageText.text = saver.MaxStage.ToString();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
