using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private KnifeSpawner _spawner;

    private int _score;
    private int _stage;
    private int _currentAppleCount;
    private StatsSaver saver;

    public int Scroe => _score;
    public int Stage => _stage;

    public event UnityAction<int> ScoreChanged;
    public event UnityAction<int> StageChanged;
    public event UnityAction<int> ApplesCountChanged;

    private void Awake()
    {
        saver = new StatsSaver();
        _score = saver.CurrentScore;
        _stage = saver.CurrentStage;
        ApplesCountChanged?.Invoke(saver.AppleCount);
    }

    private void OnEnable()
    {
        _spawner.AllKnifesInTarget += IncreaseStage;
    }

    private void OnDisable()
    {
        _spawner.AllKnifesInTarget -= IncreaseStage;
    }

    private void IncreaseStage()
    {
        _stage++;
        int currentMaxStage = saver.MaxStage;
        if (_stage > currentMaxStage)
            saver.SaveMaxStage(_stage);
        saver.SaveCurrentScore(_score);
        saver.SaveCurrentStage(_stage);
        StageChanged?.Invoke(_stage);
    }

    public void IncreaseScore()
    {
        _score++;
        int currentMaxScore = saver.MaxScore;
        if (_score > currentMaxScore)
            saver.SaveMaxScoreAmount(_score);
        ScoreChanged?.Invoke(_score);
    }


    public void IncreaseAppleCount()
    {
        _currentAppleCount = saver.AppleCount;
        _currentAppleCount++;
        saver.SaveAppleAmount(_currentAppleCount);
        ApplesCountChanged?.Invoke(_currentAppleCount);
    }
}
