using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiController : MonoBehaviour
{
   [Header("Score References")]
   [SerializeField] private TextMeshProUGUI txtScore;
   
   [Header("Game Over References")]
   [SerializeField] private GameObject gameOverPanel;

   private void Awake()
   {
      txtScore.text = "Score: 0";
   }

   public void SetScoreText(int score)
   {
      txtScore.text = FormatText(score);
   }

   public void ShowGameOverPanel()
   {
      gameOverPanel.SetActive(true);
   }

   private string FormatText(int score)
   {
      return "Score: " + score;
   }
}
