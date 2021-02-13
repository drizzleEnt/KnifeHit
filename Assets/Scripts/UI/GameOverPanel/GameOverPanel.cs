using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _scroreText;
    [SerializeField] private TMP_Text _stageText;
    [SerializeField] private TMP_Text _appleText;

    private void OnEnable()
    {
        Time.timeScale = 0f;
        StatsSaver saver = new StatsSaver();
        _appleText.text = saver.AppleCount.ToString();
        _scroreText.text = _player.Scroe.ToString();
        _stageText.text = _player.Stage.ToString();
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        StatsSaver saver = new StatsSaver();
        saver.SaveCurrentScore(0);
        saver.SaveCurrentStage(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        StatsSaver saver = new StatsSaver();
        saver.SaveCurrentScore(0);
        saver.SaveCurrentStage(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
