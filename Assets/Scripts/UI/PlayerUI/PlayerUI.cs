using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _stageText;
    [SerializeField] private TMP_Text _applesText;

    private void Awake()
    {
        StatsSaver saver = new StatsSaver();
        _applesText.text = saver.AppleCount.ToString();
        _scoreText.text = _player.Scroe.ToString();
        _stageText.text = _player.Stage.ToString();
    }

    private void OnEnable()
    {
        _player.ScoreChanged += OnScoreChanged;
        _player.StageChanged += OnStageChanged;
        _player.ApplesCountChanged += AppleCountChanged;
    }

    private void OnDisable()
    {
        _player.ScoreChanged -= OnScoreChanged;
        _player.StageChanged -= OnStageChanged;
        _player.ApplesCountChanged -= AppleCountChanged;
    }

    private void OnScoreChanged(int score)
    {
        _scoreText.text = score.ToString();
    }

    private void OnStageChanged(int stage)
    {
        _stageText.text = stage.ToString();
    }

    private void AppleCountChanged(int applesCount)
    {
        _applesText.text = applesCount.ToString();
    }
}
