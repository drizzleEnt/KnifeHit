using Singlton;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsSaver// : Singlton<StatsSaver>
{
    public int AppleCount
    { 
        get 
        {
            if (PlayerPrefs.HasKey("Apples"))
                return AppleCount = PlayerPrefs.GetInt("Apples");
            else
                return 0;
        }
        private set { }
    }
    public int MaxStage
    { 
        get 
        {
            if (PlayerPrefs.HasKey("Stage"))
                return AppleCount = PlayerPrefs.GetInt("Stage");
            else
                return 1;
        }
        private set { }
    }
    public int MaxScore 
    {
        get
        {
            if (PlayerPrefs.HasKey("Score"))
                return AppleCount = PlayerPrefs.GetInt("Score");
            else
                return 0;
        }
        private set { }
    }

    public int CurrentStage
    {
        get
        {
            if (PlayerPrefs.HasKey("CurrentStage"))
                return AppleCount = PlayerPrefs.GetInt("CurrentStage");
            else
                return 1;
        }
        private set { }
    }
    public int CurrentScore
    {
        get
        {
            if (PlayerPrefs.HasKey("CurrentScore"))
                return AppleCount = PlayerPrefs.GetInt("CurrentScore");
            else
                return 0;
        }
        private set { }
    }

    private void Awake()
    {
        if(PlayerPrefs.HasKey("Apples"))
            AppleCount = PlayerPrefs.GetInt("Apples");
        if (PlayerPrefs.HasKey("Score"))
            AppleCount = PlayerPrefs.GetInt("Score");
        
    }    

    public void SaveAppleAmount(int appleCount)
    {
        PlayerPrefs.SetInt("Apples", appleCount);
    }

    public void SaveMaxScoreAmount(int score)
    {
        PlayerPrefs.SetInt("Score", score);
    }

    public void SaveMaxStage(int stage)
    {
        PlayerPrefs.SetInt("Stage", stage);
    }

    public void SaveCurrentScore(int score)
    {
        PlayerPrefs.SetInt("CurrentScore", score);
    }

    public void SaveCurrentStage(int stage)
    {
        PlayerPrefs.SetInt("CurrentStage", stage);
    }
}


