using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UiController uiController;

    private int totalScore = 0;

    public bool isGameStarted = true;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetScore(int score)
    {
        totalScore += score;
        uiController.SetScoreText(totalScore);
        if (totalScore >= 100)
        {
            SetGameOver();
        }
    }

    public void SetGameOver()
    {
        isGameStarted = false;
        uiController.ShowGameOverPanel();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}